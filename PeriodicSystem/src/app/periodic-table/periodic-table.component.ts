import { Component, OnInit } from '@angular/core';
import { PeriodicServiceService } from '../periodic-service.service';
import { PeriodicElement } from '../PeriodicElement';

@Component({
  selector: 'app-periodic-table',
  templateUrl: './periodic-table.component.html',
  styleUrls: ['./periodic-table.component.css']
})
export class PeriodicTableComponent implements OnInit {

  elementData: PeriodicElement[][];

  colorGroups: string[] = [
    'Aquamarine',
    'Blue',
    'Green',
    'Yellow',
    'Red',
    'Gray',
    'Lime',
    'Olive',
    'Beige',
    'Coral',
    'DarkMagenta',
    'Gainsboro',
    'Gray',
    'Gold'
  ];

  constructor(private service: PeriodicServiceService)
  {
    this.elementData = service.data;
  }

  ngOnInit(): void {
  }

}
