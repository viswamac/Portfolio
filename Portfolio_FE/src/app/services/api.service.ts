import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class ApiService {

  private baseUrl = 'https://jsonplaceholder.typicode.com/todos';

  constructor(private http: HttpClient) { }

    // Example: Fetch data
    getAboutData(): Observable<any> {
      return this.http.get<any>(`${this.baseUrl}`);
    }

    getProjectData(): Observable<any> {
      return this.http.get<any>(`https://jsonplaceholder.typicode.com/users`);
    }

}
