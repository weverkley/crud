import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { CrudService } from '../../services/crud.service';

@Component({
  templateUrl: './list.component.html',
})
export class ListComponent {
  public data: any[] = [];

  constructor(private service: CrudService, private router: Router) {
    this.fetch();
  }

  fetch() {
    this.service
      .list()
      .toPromise()
      .then((response: any) => (this.data = response));
  }

  delete(id: string) {
    this.service
      .delete(id)
      .toPromise()
      .then((response: any) => this.fetch());
  }
}
