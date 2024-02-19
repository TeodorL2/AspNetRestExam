import { Component } from '@angular/core';
import { MatButtonModule } from '@angular/material/button';
import { MatIconModule } from '@angular/material/icon';
import { Router } from '@angular/router';

@Component({
  selector: 'app-nav-bar',
  templateUrl: './nav-bar.component.html',
  styleUrls: ['./nav-bar.component.css'],
  standalone: true,
  imports: [
    MatButtonModule,
    MatIconModule
  ]

})
export class NavBarComponent {

  constructor(private router: Router) { }

  getAll(): void {
    this.router.navigate(['/getAll']);
  }

  assignFilm(): void {
    this.router.navigate(['/assignFilm']);
  }

}
