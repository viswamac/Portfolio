using Porfolio_BE.Models;
using System.Text.Json;

namespace Porfolio_BE.Service
{
    public class JsonFileService
    {
        private readonly string _filePath = "data.json";

        public JsonFileService()
        {
            // Store JSON file in the root directory of the application
            _filePath = Path.Combine(Directory.GetCurrentDirectory(), "data.json");

            // Create the file if it does not exist
            if (!File.Exists(_filePath))
            {
                File.WriteAllText(_filePath, "[]"); // Initialize with an empty JSON array
            }
        }

        public List<ContactUs> ReadData()
        {
            if (!File.Exists(_filePath))
            {
                return new List<ContactUs>();
            }

            string json = File.ReadAllText(_filePath);
            return JsonSerializer.Deserialize<List<ContactUs>>(json) ?? new List<ContactUs>();
        }

        public void WriteData(List<ContactUs> records)
        {
            string json = JsonSerializer.Serialize(records, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(_filePath, json);
        }

        public ContactUs AddData(ContactUsRequestDto record)
        {
            var records = ReadData();
            var newRecord = new ContactUs
            {
                Id = records.Any() ? records.Max(c => c.Id) + 1 : 1,
                Name = record.Name,
                PhoneNumber = record.PhoneNumber,
                City = record.City,
                State = record.State,
            };
            records.Add(newRecord);
            WriteData(records);

            return newRecord;
        }

        public void UpdateData(ContactUs updatedRecord)
        {
            var records = ReadData();
            var existingRecord = records.FirstOrDefault(r => r.Id == updatedRecord.Id);

            if (existingRecord != null)
            {
                existingRecord.Name = updatedRecord.Name;
                existingRecord.PhoneNumber = updatedRecord.PhoneNumber;
                existingRecord.City = updatedRecord.City;
                existingRecord.State = updatedRecord.State;
                WriteData(records);
            }
        }

        public void DeleteData(int id)
        {
            var records = ReadData();
            var recordToRemove = records.FirstOrDefault(r => r.Id == id);

            if (recordToRemove != null)
            {
                records.Remove(recordToRemove);
                WriteData(records);
            }
        }
    }
}
