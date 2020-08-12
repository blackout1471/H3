import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { DictatorTableComponent } from './dictator-table.component';

describe('DictatorTableComponent', () => {
  let component: DictatorTableComponent;
  let fixture: ComponentFixture<DictatorTableComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ DictatorTableComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(DictatorTableComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
