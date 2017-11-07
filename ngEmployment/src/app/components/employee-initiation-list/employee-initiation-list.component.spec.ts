import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { EmployeeInitiationListComponent } from './employee-initiation-list.component';

describe('EmployeeInitiationListComponent', () => {
  let component: EmployeeInitiationListComponent;
  let fixture: ComponentFixture<EmployeeInitiationListComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ EmployeeInitiationListComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(EmployeeInitiationListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
