import { Injectable } from '@angular/core';
import { DataService } from './data.service';
import { Http } from '@angular/http';

@Injectable()
export class PositionsService extends DataService {

  constructor(http: Http) {
    super('http://localhost:5000/api/positions', http);
  }

}
