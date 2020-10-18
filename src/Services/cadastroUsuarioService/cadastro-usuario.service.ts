import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable} from 'rxjs';
import { ProviderService } from '../providers/provider.service';

@Injectable()
export class CadastroUsuarioService extends ProviderService {

  private http : HttpClient
  constructor(_http : HttpClient) { 
    super("Usuario");
    this.http = _http;
  }

  public getUsuarios() : Observable<any>{
    return this.http.get<any>(`${this.url}`);
  }

  public getUsuariosById(id : number) : Observable<any>{
    return this.http.get<any>(`${this.url}/${id}`);
  }

  public insertUsuarios(data: any) : Observable<any>{
    return this.http.post(`${this.url}`, data, {})
  }
}
