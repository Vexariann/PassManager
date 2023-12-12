import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { Observable } from 'rxjs';
import { User } from "../interfaces/user"

@Injectable({
  providedIn: 'root'
})
export class HttpServiceService {

  constructor(private http: HttpClient) { }

  baseURL: String = "https://localhost:7222";

  public createUser(user: User): Observable<any>
  {
      const url = "https://localhost:7222/user/RegisterUser"
      //var status = this.http.post<any>(url, user);
      return this.http.post<any>(url, user);
  }

  public loginUser(user: User): Observable<any>
  {
      const url = "https://localhost:7222/user/LoginUser"
      return this.http.post<any>(url, user);
  }

  public uploadImage(/*username: String, mode: Number,*/ data: String, username: String, fileName: String): Observable<any>
  {
      const url = "https://localhost:7222/user/UploadImage"
      return this.http.post<any>(url, {data, username, fileName});
  }

  public getProfilePictureByUsername(username: String)//: Observable<any>
  {
      const url = "https://localhost:7222/user/GetProfilePictureByUsername"
      const params = new HttpParams().append("username", username as string);
      return this.http.get<string>(url, {params: params});
  }
}