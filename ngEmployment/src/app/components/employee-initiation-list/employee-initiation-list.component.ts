import { Employment } from './../model-data/models';
import { NavbarComponent } from './../navbar/navbar.component';
import { Component, OnInit } from '@angular/core';
import { Router, ActivatedRoute } from '@angular/router';
import { EmploymentService } from '../../services/employment.service';

@Component({
  selector: 'app-employee-initiation-list',
  templateUrl: './employee-initiation-list.component.html',
  styleUrls: ['./employee-initiation-list.component.css']
})
export class EmployeeInitiationListComponent implements OnInit {

  employments: any[];

  employment: Employment = {
    employmentId: 0,
    fullName: '',
    phone: '',
    email: '',
    // startDate: new Date(),
    position: '',
    company: '',
  };

  constructor(
      private router: Router,
      private route: ActivatedRoute,
      private service: EmploymentService
  ) 
  { 
  }

  ngOnInit() {
    this.service.getAll()
    .subscribe( employments => this.employments = employments );
  }

  delete(){
    if(confirm("Are you sure?")){
      this.service.delete(this.employment.employmentId)
      .subscribe(x => {
        
      })

    }
  }
}
