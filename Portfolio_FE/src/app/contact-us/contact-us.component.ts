import { Component } from '@angular/core';
import {MatInputModule} from '@angular/material/input';
import {MatFormFieldModule} from '@angular/material/form-field';
import { FormGroup,FormBuilder,ReactiveFormsModule } from '@angular/forms';

@Component({
  selector: 'app-contact-us',
  imports: [MatFormFieldModule, MatInputModule, ReactiveFormsModule],
  templateUrl: './contact-us.component.html',
  styleUrl: './contact-us.component.css'
})
export class ContactUsComponent {
  myForm: FormGroup;

  constructor(private fb: FormBuilder) {
    this.myForm = this.fb.group({
      name: [''],
      phoneNumber: ['']
    });
  }

  onSubmit() {
    if (this.myForm.valid) {
      // Access the first name value from the form
      console.log('Name:', this.myForm.value.name);
      console.log('Phone:', this.myForm.value.phoneNumber);
    } else {
      console.log('Form is invalid');
    }
  }
}
