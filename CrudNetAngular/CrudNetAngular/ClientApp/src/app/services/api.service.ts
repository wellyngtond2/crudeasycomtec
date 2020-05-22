import { Injectable } from "@angular/core";
import { HttpClient } from "@angular/common/http";
import { environment } from "src/environments/environment";
import { Observable } from "rxjs";

@Injectable({
  providedIn: "root",
})
export class ApiService {
  constructor(private httpClient: HttpClient) {}

  get<T>(url: string): Observable<T> {
    return this.httpClient.get<T>(environment.BaseUrl + url);
  }

  post<T>(url: string, payload: any): Observable<T> {
    return this.httpClient.post<T>(environment.BaseUrl + url, payload);
  }

  put<T>(url: string, payload: any): Observable<T> {
    return this.httpClient.put<T>(environment.BaseUrl + url, payload);
  }

  delete<T>(url: string): Observable<T> {
    return this.httpClient.delete<T>(environment.BaseUrl + url);
  }
}
