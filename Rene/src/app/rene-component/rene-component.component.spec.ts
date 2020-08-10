import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ReneComponentComponent } from './rene-component.component';

describe('ReneComponentComponent', () => {
  let component: ReneComponentComponent;
  let fixture: ComponentFixture<ReneComponentComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ReneComponentComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ReneComponentComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
