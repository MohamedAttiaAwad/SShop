import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { ICatalogItem } from 'src/app/shared/interfaces';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class CatalogService {
  private catalogPath = environment.apiUrl + '/Catalog';
  constructor(private http:HttpClient) { }

  create(data:any):Observable<ICatalogItem>{
    return this.http.post<ICatalogItem>(this.catalogPath,data);
  }
}
