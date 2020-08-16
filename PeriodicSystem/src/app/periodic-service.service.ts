import { Injectable } from '@angular/core';
import { PeriodicElement } from './PeriodicElement';
import * as jsonData from './PeriodicSystem.json';

@Injectable({
  providedIn: 'root'
})
export class PeriodicServiceService {
  data: PeriodicElement[][] = [[]];

  constructor() {
    let jsonArr = jsonData.elements;

    // get possible ypos
    let totalY: number = new Set(jsonArr.map(values => values.ypos)).size;

    // Get maximum of columns
    let totalX: number = new Set(jsonArr.map(values => values.xpos)).size;

    // Get categories
    let categories:any[] = [...new Set(jsonArr.map(values => values.category))];

    // Create 2d array
    for (var i = 0; i < totalY; i++) {
      this.data[i] = new Array(totalX);
    }

    // Fill data
    for (var i = 0; i < jsonArr.length; i++) {
      let cur = jsonArr[i];
      let ele: PeriodicElement = new PeriodicElement(
        cur.ypos,
        categories.findIndex(val => val == cur.category),
        cur.number,
        cur.symbol,
        cur.name,
        cur.atomic_mass.toFixed(2),
        cur.shells[0]
      );

      this.data[cur.ypos - 1][cur.xpos - 1] = ele;
    }
  }

}
