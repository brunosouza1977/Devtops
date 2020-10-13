import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';


const routes: Routes = [{
  path: '',
  pathMatch: 'full',
  redirectTo: 'login'
},
{
  path: 'login',
  loadChildren: () => import('./pages/login/login.module').then(m => m.LoginModule)
},
{
  path: 'cadastro',
  loadChildren: () => import('./pages/cadastro/cadastro.module').then(m => m.CadastroModule)
},
{
  path: 'busca',
  loadChildren: () => import('./produtor/busca/busca.module').then(m => m.BuscaModule)
}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
