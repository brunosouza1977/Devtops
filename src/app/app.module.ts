import { CadastroUsuarioService } from './../Services/cadastroUsuarioService/cadastro-usuario.service';
import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { HttpClientModule } from '@angular/common/http';
import { ModalSucessoComponent } from './modal-sucesso/modal-sucesso.component';

@NgModule({
  declarations: [
    AppComponent,
    ModalSucessoComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    NgbModule,
    HttpClientModule
  ],
  providers: [CadastroUsuarioService],
  bootstrap: [AppComponent],
  entryComponents:[ModalSucessoComponent]
})
export class AppModule { }
