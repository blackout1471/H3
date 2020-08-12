import { Component, OnInit } from '@angular/core';
import { FormGroup, FormControl } from '@angular/forms';
import { Dictator } from '../Dictator';
import { ListService } from 'src/app/list.service'

@Component({
  selector: 'app-diktator-form',
  templateUrl: './diktator-form.component.html',
  styleUrls: ['./diktator-form.component.css']
})
export class DiktatorFormComponent implements OnInit {

  dictatorData: FormGroup;

  constructor(private listService: ListService) { }

  ngOnInit(): void {
    this.dictatorData = new FormGroup({
      firstName: new FormControl('Hitler'),
      lastName: new FormControl('Adolf'),
      birthYear: new FormControl('1889'),
      yearOfDeath: new FormControl('1945'),
      description: new FormControl('...')
    });
  }

  onDictatorAdded() {
    let dic: Dictator = new Dictator(
      this.dictatorData.get('firstName').value,
      this.dictatorData.get('lastName').value,
      parseInt(this.dictatorData.get('birthYear').value),
      parseInt(this.dictatorData.get('yearOfDeath').value),
      this.dictatorData.get('description').value
    );

    this.listService.addDictator(dic);
  }
}
