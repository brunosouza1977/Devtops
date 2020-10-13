import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

<<<<<<< HEAD

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
=======
const routes: Routes = [];
>>>>>>> 7884440... initial commit

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
