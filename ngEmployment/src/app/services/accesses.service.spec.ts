import { TestBed, inject } from '@angular/core/testing';

import { AccessesService } from './accesses.service';

describe('AccessesService', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [AccessesService]
    });
  });

  it('should be created', inject([AccessesService], (service: AccessesService) => {
    expect(service).toBeTruthy();
  }));
});
