import { Http } from '@angular/http';
import { Injectable } from '@angular/core';
import { DataService } from './data.service';

@Injectable()
export class CompaniesService extends DataService {

  constructor(http: Http) {
    super('http://localhost:5000/api/companies', http);
  }

}
