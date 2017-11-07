import { TestBed, inject } from '@angular/core/testing';

import { EmploymentService } from './employment.service';

describe('EmploymentService', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [EmploymentService]
    });
  });

  it('should be created', inject([EmploymentService], (service: EmploymentService) => {
    expect(service).toBeTruthy();
  }));
});
