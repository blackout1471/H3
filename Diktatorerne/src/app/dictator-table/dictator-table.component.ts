import { Component, OnInit } from '@angular/core';
import { ListService } from '../list.service';
import { Subscription } from 'rxjs';
import { Dictator } from '../Dictator';

@Component({
  selector: 'app-dictator-table',
  templateUrl: './dictator-table.component.html',
  styleUrls: ['./dictator-table.component.css']
})
export class DictatorTableComponent implements OnInit {

  public dictatorData: Dictator[] = [new Dictator('asd', 'asd', 1996, 123123, "asdasdasd")];
  private subscription: Subscription;

  constructor(private listService: ListService) { }

  ngOnInit(): void {
    this.GetList();
  }

  ngOnDestroy() {
    this.subscription.unsubscribe();
  }

  private GetList() {
    this.subscription = this.listService.getDictatorsList().subscribe(data => {
      this.dictatorData.push(data);
    });
  }

  onRemoveBtn(index: number) {
    this.dictatorData.splice(index, 1);
  }

}
