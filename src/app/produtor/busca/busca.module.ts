import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule as FormsModuleAngular, ReactiveFormsModule } from '@angular/forms';

import { BuscaRoutingModule } from './busca-routing.module';
import { BuscaComponent } from './busca.component';


@NgModule({
  declarations: [BuscaComponent],
  imports: [
    CommonModule,
    BuscaRoutingModule,
    FormsModuleAngular,
    ReactiveFormsModule
  ],
  exports : [BuscaComponent]
})
export class BuscaModule { }
