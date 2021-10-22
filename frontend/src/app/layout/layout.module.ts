import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';

import { DefaultComponent } from './default/default.component';
import { NavbarModule } from '../components/navbar/navbar.module';

@NgModule({
  imports: [CommonModule, RouterModule, NavbarModule],
  exports: [DefaultComponent],
  declarations: [DefaultComponent],
})
export class LayoutModule {}
