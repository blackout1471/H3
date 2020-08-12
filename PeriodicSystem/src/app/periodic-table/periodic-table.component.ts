import { Component, OnInit } from '@angular/core';
import { PeriodicServiceService } from '../periodic-service.service';

@Component({
  selector: 'app-periodic-table',
  templateUrl: './periodic-table.component.html',
  styleUrls: ['./periodic-table.component.css']
})
export class PeriodicTableComponent implements OnInit {

  constructor(private service: PeriodicServiceService)
  {
    console.log(service.jsonArr);
  }

  ngOnInit(): void {
  }

}
