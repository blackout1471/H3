import { Component, OnInit } from '@angular/core';

import { Square } from '../box';

@Component({
  selector: 'app-square',
  templateUrl: './square.component.html',
  styleUrls: ['./square.component.css']
})
export class SquareComponent implements OnInit {

  model: Square = new Square(2);
  areaResult: number;
  perimeterResult: number;

  constructor() { }

  ngOnInit(): void {
  }


  Calculate() {
    this.areaResult = this.model.CalculateAreal();
    this.perimeterResult = this.model.CalculatePerimeter();
  }

}
