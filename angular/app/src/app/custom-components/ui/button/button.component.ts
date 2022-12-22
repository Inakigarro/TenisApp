import { Component, EventEmitter, Input, Output } from '@angular/core';

@Component({
  selector: 'app-button',
  templateUrl: './button.component.html',
  styleUrls: ['./button.component.scss'],
})
export class ButtonComponent {
  @Input()
  public buttonType : 'stroked' | 'raised' | 'fab' | 'miniFab' = 'stroked';

  @Input()
  public label: string;
  
  @Input()
  public icon: string;

  @Output()
  public executed = new EventEmitter<string>();
}
