using Microsoft.AspNetCore.Mvc;
using Porfolio_BE.Models;
using Porfolio_BE.Service;

namespace Porfolio_BE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactUsController : ControllerBase
    {
        private readonly JsonFileService _jsonFileService;

        public ContactUsController()
        {
            _jsonFileService = new JsonFileService();
        }

        // GET: api/records
        [HttpGet]
        public ActionResult<List<ContactUs>> Get()
        {
            return Ok(_jsonFileService.ReadData());
        }

        // GET: api/records/{id}
        [HttpGet("{id}")]
        public ActionResult<ContactUs> GetById(int id)
        {
            var record = _jsonFileService.ReadData().FirstOrDefault(r => r.Id == id);
            if (record == null)
            {
                return NotFound("Record not found.");
            }
            return Ok(record);
        }

        // POST: api/records
        [HttpPost]
        public ActionResult<ContactUs> Post([FromBody] ContactUsRequestDto newRecord)
        {
            var records = _jsonFileService.ReadData();

            var savedRecord = _jsonFileService.AddData(newRecord);
            return CreatedAtAction(nameof(GetById), new { id = savedRecord.Id }, savedRecord);
        }

        // PUT: api/records/{id}
        [HttpPut("{id}")]
        public ActionResult Update(int id, [FromBody] ContactUs updatedRecord)
        {
            var records = _jsonFileService.ReadData();
            var existingRecord = records.FirstOrDefault(r => r.Id == id);

            if (existingRecord == null)
            {
                return NotFound("Record not found.");
            }

            _jsonFileService.UpdateData(updatedRecord);
            return NoContent(); // 204 No Content response
        }

        // DELETE: api/records/{id}
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var records = _jsonFileService.ReadData();

            if (!records.Any(r => r.Id == id))
            {
                return NotFound("Record not found.");
            }

            _jsonFileService.DeleteData(id);
            return NoContent(); // 204 No Content response
        }
    }
}
