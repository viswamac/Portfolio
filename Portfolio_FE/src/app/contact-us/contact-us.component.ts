import { Component } from '@angular/core';
import {MatInputModule} from '@angular/material/input';
import {MatFormFieldModule} from '@angular/material/form-field';
import { FormGroup,FormBuilder,ReactiveFormsModule, Validators } from '@angular/forms';
import { CommonModule } from '@angular/common';
import { HeaderComponent } from '../header/header.component';
import {MatCardModule} from '@angular/material/card';
import { MatButtonModule } from '@angular/material/button';

@Component({
  selector: 'app-contact-us',
  imports: [
    MatFormFieldModule,
    MatInputModule,
    ReactiveFormsModule,
    CommonModule,
    HeaderComponent,
    MatCardModule,
  MatButtonModule],
  templateUrl: './contact-us.component.html',
  styleUrl: './contact-us.component.css'
})
export class ContactUsComponent {
  myForm: FormGroup;

  constructor(private fb: FormBuilder) {
    this.myForm = this.fb.group({
      name: ['',[Validators.required,Validators.minLength(5)]],
      phoneNumber: ['',Validators.required],
      address: this.fb.group({
        city: [''],
        state: ['']
    })});
  }

  onSubmit() {
    if (this.myForm.valid) {
      // Access the first name value from the form
      console.log('Name:', this.myForm.value.name);
      console.log('Phone:', this.myForm.value.phoneNumber);
      console.log('City:', this.myForm.value.address.city);
      console.log('State:', this.myForm.value.address.state);
    } else {
      console.log('Form is invalid');
    }
    this.myForm.reset();
  }

  update(){
    this.myForm.patchValue({
      name: 'John Doe',
      phoneNumber: '1234567890',
      address: {
        city: 'New York',
        state: 'NY'
    }});
  }
}
