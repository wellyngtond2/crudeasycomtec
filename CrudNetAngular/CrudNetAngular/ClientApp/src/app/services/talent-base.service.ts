import { Injectable } from "@angular/core";
import { ApiService } from "./api.service";
import { Observable } from "rxjs";
import { talentBaseMode } from "../talent-base/model/talen-base.model";

@Injectable({
  providedIn: "root",
})
export class TalentBaseService {
  private readonly endpoint = "/talen-base";

  constructor(private apiService: ApiService) {}

  getAll(): Observable<talentBaseMode[]> {
    return this.apiService.get<talentBaseMode[]>(`${this.endpoint}`);
  }

  get(talentId: string): Observable<talentBaseMode> {
    return this.apiService.get<talentBaseMode>(`${this.endpoint}/${talentId}`);
  }

  save(talentBase: talentBaseMode): Observable<string> {
    return !talentBase.id
      ? this.apiService.post<string>(this.endpoint, talentBase)
      : this.apiService.put<string>(this.endpoint, talentBase);
  }

  delete(talentId: string): Observable<any> {
    return this.apiService.delete(`${this.endpoint}/${talentId}`);
  }
}
