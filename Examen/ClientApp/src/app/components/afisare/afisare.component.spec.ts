import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AfisareComponent } from './afisare.component';

describe('AfisareComponent', () => {
  let component: AfisareComponent;
  let fixture: ComponentFixture<AfisareComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AfisareComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(AfisareComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
