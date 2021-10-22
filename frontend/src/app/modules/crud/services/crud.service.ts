import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { environment } from 'src/environments/environment';

const headers = new HttpHeaders({
  'Content-Type': 'application/json',
  Accept: 'application/json',
});

const httpOptions = {
  headers: headers,
};

@Injectable()
export class CrudService {
  constructor(private http: HttpClient) {}

  list() {
    return this.http.get(`${environment.apiUrl}/crud`, httpOptions);
  }

  getById(id: string) {
    return this.http.get(`${environment.apiUrl}/crud/${id}`, httpOptions);
  }

  create(data: any) {
    return this.http.post(`${environment.apiUrl}/crud`, data, httpOptions);
  }

  update(data: any) {
    return this.http.put(
      `${environment.apiUrl}/crud/${data.id}`,
      data,
      httpOptions
    );
  }

  delete(id: string) {
    return this.http.delete(`${environment.apiUrl}/crud/${id}`, httpOptions);
  }
}
