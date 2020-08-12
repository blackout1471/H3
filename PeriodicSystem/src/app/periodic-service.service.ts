import { Injectable } from '@angular/core';
import { PeriodicElement } from './PeriodicElement';
import jsonData from './PeriodicSystem.json';

@Injectable({
  providedIn: 'root'
})
export class PeriodicServiceService {
  jsonArr;

  constructor() {
    this.jsonArr = jsonData;
  }

}
