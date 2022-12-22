import { Component } from '@angular/core';
import { MatToolbarModule } from '@angular/material/toolbar';
import { MatIconModule } from '@angular/material/icon'
import { MatButtonModule } from '@angular/material/button';
import { CommonModule } from '@angular/common';

const materialModules = [
  MatToolbarModule,
  MatIconModule,
  MatButtonModule,
  CommonModule
];

@Component({
  selector: 'app-tool-bar',
  templateUrl: './tool-bar.component.html',
  styleUrls: ['./tool-bar.component.scss'],
  standalone: true,
  imports: [materialModules]
})
export class ToolBarComponent {
  public menuActive = true;

  public changeStateMenu(){
    this.menuActive = !this.menuActive;
  }
}
