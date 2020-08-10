import { Component, OnInit } from '@angular/core';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms'

import { Rectangle } from '../Box';

@Component({
  selector: 'app-rectangle',
  templateUrl: './rectangle.component.html',
  styleUrls: ['./rectangle.component.css']
})
export class RectangleComponent implements OnInit {

  model: Rectangle = new Rectangle(2, 2);

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
