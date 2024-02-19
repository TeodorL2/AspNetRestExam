import { Component, OnInit } from '@angular/core';
import { Film } from '../../data/interfaces/film';
import { ApiService } from '../../core/services/api.service';
import { Actor } from '../../data/interfaces/actor';
import { CommonModule } from '@angular/common';
import { MatCardModule } from '@angular/material/card';

@Component({
  selector: 'app-afisare',
  templateUrl: './afisare.component.html',
  styleUrls: ['./afisare.component.css'],
  standalone: true,
  imports: [
    CommonModule,
    MatCardModule
  ]
})
export class AfisareComponent implements OnInit {
  private readonly pathFilme: string = "/examen/filme";
  private readonly pathActori: string = "/examen/actori";
  private readonly pathGroup: string = "/examen/actoriDupaFilme";

  public filme: Film[] = [];
  public actori: Actor[] = [];
  public group: any;

  constructor(private readonly apiService: ApiService) {
   
  }

  ngOnInit() {
    this.apiService.get(this.pathFilme).subscribe(
      (data: any) => {
        this.filme = data;
      },
      (error: any) => {
        console.error(error.error.message);
      });

    this.apiService.get(this.pathActori).subscribe(
      (data: any) => {
        this.actori = data;
      },
      (error: any) => {
        console.error(error.error.message);
      });
/*
            this.apiService.get(this.pathGroup).subscribe(
              (data: any) => {
                this.group = data;
              },
              (error: any) => {
                console.error(error.error.message);
              });
        */
  }


}
