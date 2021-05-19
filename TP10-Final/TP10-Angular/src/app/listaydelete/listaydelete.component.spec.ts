import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ListaydeleteComponent } from './listaydelete.component';

describe('ListaydeleteComponent', () => {
  let component: ListaydeleteComponent;
  let fixture: ComponentFixture<ListaydeleteComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ListaydeleteComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ListaydeleteComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
