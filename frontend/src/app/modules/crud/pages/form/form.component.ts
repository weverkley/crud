import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { CrudService } from '../../services/crud.service';

@Component({
  templateUrl: './form.component.html',
})
export class FormComponent implements OnInit {
  public form: FormGroup;
  public id: string;
  public isEditing: boolean;

  constructor(
    private route: ActivatedRoute,
    private service: CrudService,
    private router: Router
  ) {
    this.id = this.route.snapshot.params.id;
    this.isEditing = this.id ? true : false;

    this.form = new FormGroup({
      id: new FormControl(''),
      email: new FormControl('', [Validators.required, Validators.email]),
      value: new FormControl(null, [Validators.required, Validators.min(1)]),
    });

    if (this.isEditing) {
      this.service
        .getById(this.id)
        .toPromise()
        .then((response: any) => {
          this.form.patchValue({
            id: response.id,
            email: response.email,
            value: response.value,
          });
          this.form.updateValueAndValidity();
        });
    }
  }

  ngOnInit() {}

  onSubmit(e: any) {
    const data = this.form.value;
    if (!this.isEditing) {
      delete data.id;
      this.service
        .create(data)
        .toPromise()
        .then((response: any) => {
          this.router.navigateByUrl('/');
        });
    } else {
      this.service
        .update(data)
        .toPromise()
        .then((response: any) => {
          this.router.navigateByUrl('/');
        });
    }
  }
}
