import { Company, Access, SaveEmployment } from './../model-data/models';
import { AccessesService } from './../../services/accesses.service';
import { EquipmentsService } from './../../services/equipments.service';
import { CompaniesService } from './../../services/companies.service';
import { Component, OnInit } from '@angular/core';
import { Router, ActivatedRoute } from '@angular/router';
import { PositionsService } from '../../services/positions.service';
import { EmploymentService } from '../../services/employment.service';

@Component({
  selector: 'app-employee-initiation-form',
  templateUrl: './employee-initiation-form.component.html',
  styleUrls: ['./employee-initiation-form.component.css']
})
export class EmployeeInitiationFormComponent implements OnInit {

  employment: SaveEmployment = {
    id: 0,
    fullName: null,
    phone: null,
    email: null,
    startDate: new Date(),
    managerEmail: null,
    restrictedAccess: null,
    additionalInfo: null,
    additionalService: null,
    otherPosition: null,
    otherComapny: null,
    otherAccesses: null,
    otherServices: null,
    companyId: 0,
    positionId: 0,
    accesses: [],
    equipments: []
  };


  companies: any[];
  accesses: any[];
  positions: any[];
  equipments: any[];

  accessByCompany: any[];
  

  tab1: boolean = true;
  tab2: boolean = false;
  tab3: boolean = false;

  constructor(
    private router: Router,
    private route: ActivatedRoute,
    private servicePosition: PositionsService,
    private serviceCompany: CompaniesService,
    private serviceEquipment: EquipmentsService,
    private serviceAccess: AccessesService,
    private serviceEmployment: EmploymentService
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

  // onCompanyChange(){
  //   // console.log("The comany was changed!", this.employment);
  //   var selectedCompany = this.companies.find(c => c.id == this.employment.companyId);
  //   // this.accesses = selectedCompany.accesses;
  //   this.serviceCompany.getById(selectedCompany.id)
  //   .subscribe(accessesByCompany => accessesByCompany = accessesByCompany);
  //   console.log(selectedCompany);
  //   console.log(selectedCompany.id);
  //   console.log(selectedCompany.name);
  // }

  onEquipmentToggle(equipmentId, $event){
    if($event.target.checked)
      this.employment.equipments.push(equipmentId);
    else{
      var index = this.employment.equipments.indexOf(equipmentId);
      this.employment.equipments.splice(index, 1);
    }
  }

  onAccessToggle(accessId, $event){
    if($event.target.checked)
      this.employment.accesses.push(accessId);
    else{
      var index = this.employment.accesses.indexOf(accessId);
      this.employment.accesses.splice(index, 1);
    }
  }

  submit(){
    this.serviceEmployment.createEmployment(this.employment)
    .subscribe(
      x => console.log(x),
      err => {
        
      });
    this.router.navigate(['/employments']);
  }

  nextTab(){
    if(this.tab1){
      this.tab1 = false;
      this.tab2 = true;
    }
    else if(this.tab2){
      this.tab2 = false;
      this.tab3 = true;
    }
  }

  prevTab(){
    if(this.tab2){
      this.tab2 = false;
      this.tab1 = true;
    }
    else if(this.tab3){
      this.tab3 = false;
      this.tab2 = true;
    }
  }
}

