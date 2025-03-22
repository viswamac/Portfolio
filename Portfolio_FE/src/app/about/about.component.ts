import { Component } from '@angular/core';
import { ApiService } from '../services/api.service';

@Component({
  selector: 'app-about',
  imports: [],
  templateUrl: './about.component.html',
  styleUrl: './about.component.css'
})
export class AboutComponent {
  data: any;
  aboutContent: string = "";

  constructor(private apiService: ApiService) {}

  ngOnInit(): void {
    this.apiService.getAboutData().subscribe(response => {
      this.data = response;
      this.aboutContent = this.data[0].title;
      
      this.aboutContent = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Blanditiis libero, fuga saepe tempore voluptatum dolorem at perspiciatis fugit sit facilis veniam nemo quia quisquam sapiente corporis cupiditate ab amet exercitationem?";
    });
  }
}
