import { AccessesService } from './../../services/accesses.service';
import { EquipmentsService } from './../../services/equipments.service';
import { CompaniesService } from './../../services/companies.service';
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
  equipments: any[];
  companies: any[];
  accesses: any[];

  // tab1: boolean = true;
  // tab2: boolean = false;
  // tab3: boolean = false;

  constructor(
    private router: Router,
    private route: ActivatedRoute,
    private servicePosition: PositionsService,
    private serviceCompany: CompaniesService,
    private serviceEquipment: EquipmentsService,
    private serviceAccess: AccessesService
  ) { }

  ngOnInit() {
    this.servicePosition.getAll()
    .subscribe( positions => this.positions = positions );

    this.serviceEquipment.getAll()
    .subscribe( equipments => this.equipments = equipments );

    this.serviceCompany.getAll()
    .subscribe( companies => this.companies = companies );

    this.serviceAccess.getAll()
    .subscribe( accesses => this.accesses = accesses );
  }

  // nextTab(){
  //   if(this.tab1 && !this.tab2 && !this.tab3){
  //     this.tab1 = false;
  //     this.tab2 = true; 
  //   }
  //   else if(!this.tab1 && this.tab2 && !this.tab3){
  //     this.tab2 = false;
  //     this.tab3 = true; 
  //   }
  // }

  // prevTab(){
  //   if(this.tab2 && !this.tab3){
  //     this.tab1 = true;
  //     this.tab2 = false; 
  //   }
  //   else if(!this.tab2 && this.tab3){
  //     this.tab2 = true;
  //     this.tab3 = false; 
  //   }
  // }

}
