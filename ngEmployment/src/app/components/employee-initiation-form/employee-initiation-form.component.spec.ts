import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { EmployeeInitiationFormComponent } from './employee-initiation-form.component';

describe('EmployeeInitiationFormComponent', () => {
  let component: EmployeeInitiationFormComponent;
  let fixture: ComponentFixture<EmployeeInitiationFormComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ EmployeeInitiationFormComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(EmployeeInitiationFormComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
