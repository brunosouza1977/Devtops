export class Usuarios {
    constructor(
       public nome: string,
       public cpf: number,
       public login: string,
       public senha: string,
       public tipoperfil: number,
       public cache: number,
       public generoobra: number,
       public datadisponibilidade: Date,
       public cidade: string,
       public estado: string,
       public cep: number, 
    ){}
}