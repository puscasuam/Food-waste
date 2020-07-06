import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { IPagination } from '../shared/models/pagination';
import { IDiet } from '../shared/models/diet';
import { IType } from '../shared/models/productType';
import { map } from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})
export class ShopService {

  baseUrl = 'https://localhost:5001/api/';

  constructor(private http: HttpClient) { }

  getProducts(dietId?: number, typeId?: number) {

    let params = new HttpParams;

    if (dietId) {
      params = params.append('dietId', dietId.toString());
    }

    if (typeId) {
      params = params.append('typeId', typeId.toString());
    }

    return this.http.get<IPagination>(this.baseUrl + 'products', { observe: 'response', params })
      .pipe(
        map(response => {
          return response.body;
        })
      );
  }

  getDiets() {
    return this.http.get <IDiet[]>(this.baseUrl + 'products/diets');
  }

  getTypes() {
    return this.http.get<IType[]>(this.baseUrl + 'products/types');
  }
}
