import { Router } from '@angular/router';
import { Component, OnInit } from '@angular/core';
import { FormGroup, FormControl, Validators } from '@angular/forms';
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

  constructor(private _usuarioService: CadastroUsuarioService, private router: Router) {}

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
    get nome (){
      return this.basicForm.get('nome');
    }
    
    get cpf (){
      return this.basicForm.get('cpf');
    }
    get login (){
      return this.basicForm.get('login');
    }
    get senha (){
      return this.basicForm.get('senha');
    }
    get tipoPerfil (){
      return this.basicForm.get('tipoPerfil');
    }
    get cache (){
      return this.basicForm.get('cache');
    }
    get generoobra (){
      return this.basicForm.get('generoobra');
    }
    get dataDisponibilidade (){
      return this.basicForm.get('dataDisponibilidade');
    }

    get cidade (){
      return this.basicForm.get('cidade');
    }
    get estado (){
      return this.basicForm.get('estado');
    }
    get cep (){
      return this.basicForm.get('cep');
    }
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
                                    this.router.navigate(['/login']);
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

