import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { DefaultComponent } from './layout/default/default.component';
import { LayoutModule } from './layout/layout.module';

const routes: Routes = [
  {
    path: '',
    component: DefaultComponent,
    children: [
      {
        path: '',
        loadChildren: () =>
          import('./modules/crud/crud.module').then((m) => m.CrudModule),
      },
    ],
  },
];

@NgModule({
  imports: [RouterModule.forRoot(routes), LayoutModule],
  exports: [RouterModule],
})
export class AppRoutingModule {}
