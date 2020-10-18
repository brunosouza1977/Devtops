import { Component, OnInit } from '@angular/core';
import { FormGroup, FormControl, Validators, FormBuilder } from '@angular/forms';
import { CadastroUsuarioService } from './../../../Services/cadastroUsuarioService/cadastro-usuario.service';
import { Usuarios } from './../../../Services/models/usuarios';
import  estados from '../../Shared/Mocks/estados.js';
import  cidades from '../../Shared/Mocks/cidades.js';

@Component({
  selector: 'app-cadastro',
  templateUrl: './cadastro.component.html',
  styleUrls: ['./cadastro.component.scss']
})
export class CadastroComponent implements OnInit {
  public usuario = {};
  basicForm: FormGroup;
  endereco: any ={
    estado: {}
  }

  constructor(private _usuarioService: CadastroUsuarioService) {}

  ngOnInit(): void {
    this.basicForm = new FormGroup({
      nome: new FormControl('', Validators.required),
      cpf: new FormControl('', Validators.required),
      login: new FormControl('', Validators.required),
      senha: new FormControl('', Validators.required),
      tipoPerfil: new FormControl('', Validators.required),
      cache: new FormControl('', Validators.required),
      generoobra: new FormControl('', Validators.required),
      dataDisponibilidade: new FormControl('', Validators.required),
      cidade: new FormControl('', Validators.required),
      estado: new FormControl('', Validators.required),
      cep: new FormControl('', Validators.required)
    })
  }

  /**
   * core.js:4352 ERROR Error: formGroup expects a FormGroup instance. Please pass one in.

       Example:

       
    <div [formGroup]="myGroup">
      <input formControlName="firstName">
    </div>

    In your class:

    this.myGroup = new FormGroup({
       firstName: new FormControl()
    });
   */

  onSubmit(){
    var usuario = new Usuarios(this.basicForm.controls.nome.value,
                               Number(this.basicForm.controls.cpf.value),
                               this.basicForm.controls.login.value,
                               this.basicForm.controls.senha.value,
                               Number(this.basicForm.controls.tipoPerfil.value),
                               Number(this.basicForm.controls.cache.value),
                               Number(this.basicForm.controls.generoobra.value),
                               this.basicForm.controls.dataDisponibilidade.value,
                               this.basicForm.controls.cidade.value,
                               this.basicForm.controls.estado.value,
                               Number(this.basicForm.controls.cep.value));

     var data = JSON.stringify(usuario);
      console.log(data);
      this._usuarioService.insertUsuarios(JSON.parse(data))
                                .subscribe(
                                  (response: any) =>{
                                    alert("Usuário Cadastrado com Sucesso!");
                                  },
                                  (error: any) =>{
                                    alert("Erro ao Inserir Usuario");
                                  }
                                )    
  }

  getCidadesByEstado(estado){
    return cidades.filter(cidade => cidade.estado === estado)
  }

  get estados () {
    return estados
  }

}

