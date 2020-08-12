import { Injectable } from '@angular/core';
import { Subject, Observable } from 'rxjs';
import { Dictator } from './Dictator';

@Injectable({
  providedIn: 'root'
})
export class ListService {
  private listSubject: Subject<Dictator> = new Subject<Dictator>();

  constructor() { }

  public addDictator(item: Dictator) {
    this.listSubject.next(item);
  }

  public getDictatorsList(): Observable<Dictator> {
    return this.listSubject.asObservable();
  }
}
