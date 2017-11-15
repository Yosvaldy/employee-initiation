import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';
import { AppComponent } from './app.component';
import { NavbarComponent } from './components/navbar/navbar.component';
import { HomeComponent } from './components/home/home.component';
import { HttpModule } from '@angular/http';
import { ErrorHandler } from '@angular/core';
import { ReactiveFormsModule, FormsModule } from '@angular/forms';
import { EmployeeInitiationListComponent } from './components/employee-initiation-list/employee-initiation-list.component';
import { EmploymentService } from './services/employment.service';
import { EmployeeInitiationFormComponent } from './components/employee-initiation-form/employee-initiation-form.component';
import { PositionsService } from './services/positions.service';
import { CompaniesService } from './services/companies.service';
import { EquipmentsService } from './services/equipments.service';
import { AccessesService } from './services/accesses.service';


@NgModule({
  declarations: [
    AppComponent,
    NavbarComponent,
    HomeComponent,
    EmployeeInitiationListComponent,
    EmployeeInitiationFormComponent
  ],
  imports: [
    BrowserModule,
    HttpModule,
    FormsModule,
    ReactiveFormsModule,
    RouterModule.forRoot([
      { 
        path: '', component: HomeComponent 
      },
      { 
        path: 'new-initiation', component: EmployeeInitiationFormComponent 
      },
      { 
        path: 'employments', component: EmployeeInitiationListComponent 
      },
      { 
        path: '**', component: HomeComponent 
      },
    ])
  ],
  providers: [
    EmploymentService,
    PositionsService,
    CompaniesService,
    EquipmentsService,
    AccessesService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
