import { Injectable } from '@angular/core';
import {HttpClient} from '@angular/common/http';
import {Observable} from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class AuthService {
    private baseUrl = 'http://localhost:5128/';

  constructor(private http: HttpClient) { }

  authLogin(email: string, password: string) : Observable<any>{
    const body={email,password};
    return this.http.post<any>(`${this.baseUrl}` + "api/Authentication/login", body);
  }

  authRegister(name: string, email: string, password: string, gender: string): Observable<any> {
    const body = {
      Email: email,
      Password: password,
      PersonName: name,
      Gender: gender
    };
    return this.http.post<any>(`${this.baseUrl}api/Authentication/register`, body);
  }

}
