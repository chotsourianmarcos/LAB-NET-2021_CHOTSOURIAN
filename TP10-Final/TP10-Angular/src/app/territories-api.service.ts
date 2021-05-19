import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { Territories } from './territories';

@Injectable()
export class TerritoriesAPIService {
  constructor(private httpclient: HttpClient) { }

  getTerritories(): Observable<any> {
    return this.httpclient.get(environment.territories)
  }

  deleteTerritory(id: string): Observable<{}> {
    return this.httpclient.delete(environment.territories + "/" + id);
  }

  addTerritory(ingresado: Territories) {
    return this.httpclient.post(environment.territories, ingresado, { observe: 'response' })
      .subscribe(
        res => {
          window.location.reload()
        },
        error => {
          alert("Hubo un error. Verifique los datos.")
        });
  }

  updateTerritory(ingresado: Territories) {
    return this.httpclient.patch(environment.territories, ingresado, { observe: 'response' })
      .subscribe(
        res => {
          window.location.reload()
        },
        error => {
          alert("Hubo un error. Verifique los datos.")
        });
  }
}

