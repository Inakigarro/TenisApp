import { Component, NgModule } from '@angular/core';

@Component({
  selector: 'app-main',
  templateUrl: './main.component.html',
  styleUrls: ['./main.component.scss']
})
export class MainComponent {

}

@NgModule({
  declarations:[MainComponent],
  imports:[],
  exports: [
    MainComponent
  ]
})
export class MainModule {}
