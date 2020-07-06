import { Component, OnInit } from '@angular/core';
import { IProduct } from '../shared/models/product';
import { ShopService } from './shop.service';
import { IDiet } from '../shared/models/diet';
import { IType } from '../shared/models/productType';

@Component({
  selector: 'app-shop',
  templateUrl: './shop.component.html',
  styleUrls: ['./shop.component.scss']
})
export class ShopComponent implements OnInit {
  products: IProduct[];
  diets: IDiet[];
  types: IType[];
  dietIdSelected: number;
  typeIdSelected: number;
  sortSelected = 'name';
  sortOptions = [
    { name: 'Alphabetical', value: 'name' },
    { name: 'Price: Low to High', value: 'priceAsc' },
    { name: 'Price: High to Low', value: 'priceDesc' }
  ];

  constructor(private shopService: ShopService) { }

  ngOnInit() {
    this.getProducts();
    this.getDiets();
    this.getTypes();


    console.log(this.getTypes());
  }

  getProducts() {
    this.shopService.getProducts(this.dietIdSelected, this.typeIdSelected, this.sortSelected).subscribe(response => {
      this.products = response.data;
    }, error => {
      console.log(error);
    });
  }

  getDiets() {
    this.shopService.getDiets().subscribe(response => {
      this.diets = response;
    }, error => {
      console.log(error);
    });
  }

  getTypes() {
    this.shopService.getTypes().subscribe(response => {
      this.types = response;
    }, error => {
      console.log(error);
    });
  }

  onDietSelected(dietId: number) {
    this.dietIdSelected = dietId;
    this.getProducts();
  }

  onTypeSelected(typeId: number) {
    this.typeIdSelected = typeId;
    this.getProducts();
  }

  onSortSelected(sort: string) {
    this.sortSelected = sort;
    this.getProducts();
  }
}
