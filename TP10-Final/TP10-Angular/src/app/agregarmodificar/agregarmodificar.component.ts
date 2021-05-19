import { Component, OnInit } from '@angular/core';
import { TerritoriesAPIService } from '../territories-api.service';
import { Territories } from '../territories';
import { FormControl, FormGroup, Validators } from '@angular/forms';


@Component({
  selector: 'app-agregarmodificar',
  templateUrl: './agregarmodificar.component.html',
  styleUrls: ['./agregarmodificar.component.scss']
})
export class AgregarmodificarComponent implements OnInit {

  constructor(public territoriesAPI: TerritoriesAPIService) {
  }

  territoriesList: Territories[];

  ngOnInit() {
    this.territoriesAPI.getTerritories()
      .subscribe(
        data => {
          this.territoriesList = data;
        });

  }

  formulario = new FormGroup({
    TerritoryID: new FormControl('', Validators.required),
    TerritoryDescription: new FormControl('', Validators.required),
    RegionID: new FormControl('', Validators.required),
  });

  ingresado: Territories = new Territories;

  onSubmit() {
    this.ingresado = this.formulario.value;
    if (this.territoriesList.some(x => x.TerritoryID == this.ingresado.TerritoryID)) {
      this.territoriesAPI.updateTerritory(this.ingresado);
    } else {
      this.territoriesAPI.addTerritory(this.ingresado);
    }
  }


}

