import { Component, OnInit } from '@angular/core';
import { Router, ActivatedRoute } from '@angular/router';
import { PositionsService } from '../../services/positions.service';

@Component({
  selector: 'app-employee-initiation-form',
  templateUrl: './employee-initiation-form.component.html',
  styleUrls: ['./employee-initiation-form.component.css']
})
export class EmployeeInitiationFormComponent implements OnInit {
  positions: any[];


  constructor(
    private router: Router,
    private route: ActivatedRoute,
    private service: PositionsService
  ) { }

  ngOnInit() {
    this.service.getAll()
    .subscribe( positions => this.positions = positions );
  }

}
