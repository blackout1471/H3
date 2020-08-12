import { TestBed } from '@angular/core/testing';

import { PeriodicServiceService } from './periodic-service.service';

describe('PeriodicServiceService', () => {
  let service: PeriodicServiceService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(PeriodicServiceService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
