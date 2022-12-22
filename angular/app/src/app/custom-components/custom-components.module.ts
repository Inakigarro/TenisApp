import { NgModule } from "@angular/core";
import { MatButtonModule } from '@angular/material/button';
import { MatIconModule } from '@angular/material/icon';
import { CommonModule } from '@angular/common';
import { ButtonComponent } from "./ui/button/button.component";

@NgModule({
    declarations: [ButtonComponent],
    exports: [ButtonComponent],
    imports:[
        CommonModule,
        MatButtonModule,
        MatIconModule]
})
export class CustomComponentsModule{}