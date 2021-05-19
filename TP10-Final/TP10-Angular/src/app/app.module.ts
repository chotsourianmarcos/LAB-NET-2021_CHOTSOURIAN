import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';

import { HttpClientModule } from '@angular/common/http';
import { TerritoriesAPIService } from './territories-api.service';
import { ReactiveFormsModule } from '@angular/forms';
import { AgregarmodificarComponent } from './agregarmodificar/agregarmodificar.component';
import { ListaydeleteComponent } from './listaydelete/listaydelete.component';
import { MatTableModule} from '@angular/material/table';

@NgModule({
  declarations: [
    AppComponent,
    AgregarmodificarComponent,
    ListaydeleteComponent
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    ReactiveFormsModule,
    MatTableModule,
  ],
  providers: [TerritoriesAPIService],
  bootstrap: [AppComponent]
})
export class AppModule { }
