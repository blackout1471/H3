import { Component, OnInit, Input } from '@angular/core';
import { PeriodicElement } from '../PeriodicElement';

@Component({
  selector: 'app-element',
  templateUrl: './element.component.html',
  styleUrls: ['./element.component.css']
})
export class ElementComponent implements OnInit {

  @Input('Element')
  element: PeriodicElement = new PeriodicElement(0, 0, 0, "UK", "Unknown", 0, 0);

  @Input('Color')
  color: string = "White"; // White color


  constructor() { }

  ngOnInit(): void {
  }

}
