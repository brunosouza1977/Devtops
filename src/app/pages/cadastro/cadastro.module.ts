import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule as FormsModuleAngular, ReactiveFormsModule } from '@angular/forms';

import { CadastroRoutingModule } from './cadastro-routing.module';
import { CadastroComponent } from './cadastro.component';


@NgModule({
  declarations: [CadastroComponent],
  imports: [
    CommonModule,
    CadastroRoutingModule,
    FormsModuleAngular,
    ReactiveFormsModule
    ],
  exports : [CadastroComponent]
})
export class CadastroModule { }
