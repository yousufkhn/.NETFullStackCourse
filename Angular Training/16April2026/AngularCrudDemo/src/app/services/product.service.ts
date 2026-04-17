import { Injectable } from '@angular/core';
import { Product } from '../models/product.model';
import { BehaviorSubject, Observable } from 'rxjs';

@Injectable({
  providedIn: 'root',
})
export class ProductService {
  private products : Product[] = [];
  private productsSubject = new BehaviorSubject<Product[]>([]);
  public products$ = this.productsSubject.asObservable();

  private currentId = 1;

  constructor(){
    this.loadSampleData();
  }

  private loadSampleData():void{
    this.products =[
      {
        id: this.currentId++,
        name: 'Laptop',
        price: 999.99,
        description: 'High-performance laptop with 16GB RAM',
        category: 'Electronics',
        inStock: true
      },{
        id: this.currentId++,
        name: 'Coffee Mug',
        price: 15.99,
        description: 'Ceramic coffee mug, 350ml',
        category: 'Kitchen',
        inStock: true
      },
      {
        id: this.currentId++,
        name: 'Notebook',
        price: 5.99,
        description: '100-page ruled notebook',
        category: 'Stationery',
        inStock: false
      }
    ];
    this.productsSubject.next([...this.products]);
  }

  getProducts():Observable<Product[]>{
    return this.products$;
  }

  
}
