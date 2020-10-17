import { Component, OnInit } from '@angular/core';
import { FormGroup, FormControl, Validators } from '@angular/forms'
import { estadosList} from '../../Shared/Mocks/estados.js';
import { CidadesList} from '../../Shared/Mocks/cidades.js';


@Component({
  selector: 'app-cadastro',
  templateUrl: './cadastro.component.html',
  styleUrls: ['./cadastro.component.scss']
})
export class CadastroComponent implements OnInit {

  basicForm: FormGroup;

  list: any = {
    estados: {}
  }
  
  constructor() { }

  ngOnInit(): void {

  }
  
  getCidadesByEstado(estado){
    return CidadesList.filter(cidade => cidade.estado === estado)
  }

  get estados (){
    return estadosList
  }

}

