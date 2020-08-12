import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { DiktatorFormComponent } from './diktator-form.component';

describe('DiktatorFormComponent', () => {
  let component: DiktatorFormComponent;
  let fixture: ComponentFixture<DiktatorFormComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ DiktatorFormComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(DiktatorFormComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
