import { Component } from '@angular/core';
import { AgregarmodificarComponent } from '../agregarmodificar/agregarmodificar.component';

@Component({
  selector: 'app-listaydelete',
  templateUrl: './listaydelete.component.html',
  styleUrls: ['./listaydelete.component.scss']
})
export class ListaydeleteComponent extends AgregarmodificarComponent {
  
  columnsToDisplay = ['position', 'name', 'weight', 'delete'];

  onDelete(id: string): void {
    this.territoriesAPI.deleteTerritory(id).subscribe()
    window.location.reload();
  }

}
