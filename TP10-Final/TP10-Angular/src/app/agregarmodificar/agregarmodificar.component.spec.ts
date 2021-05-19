import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AgregarmodificarComponent } from './agregarmodificar.component';

describe('AgregarmodificarComponent', () => {
  let component: AgregarmodificarComponent;
  let fixture: ComponentFixture<AgregarmodificarComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [AgregarmodificarComponent]
    })
      .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(AgregarmodificarComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
