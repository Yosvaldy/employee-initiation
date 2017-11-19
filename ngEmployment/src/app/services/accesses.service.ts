import { Injectable } from '@angular/core';
import { DataService } from './data.service';
import { Http } from '@angular/http';

@Injectable()
export class AccessesService extends DataService {

  constructor(http: Http) {
    super('http://localhost/ngemploy/api/accesses', http);
  }

}
