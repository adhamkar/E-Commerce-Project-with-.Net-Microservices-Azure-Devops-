import { Component, OnInit} from '@angular/core';
import { AuthService } from '../../../Services/Auth-Service/auth.service';
import { Router } from '@angular/router';
@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrl: './register.component.css'
})
export class RegisterComponent implements OnInit {
    isClicked: boolean = false;
    value1: string | undefined;
    value0: string | undefined;
    value2: string | undefined;
    genders: any[] | undefined;

    selectedGender: any;

    constructor(private authService: AuthService,private route: Router) {}

    
    ngOnInit() {
      this.genders = [
        {
                label: 'M',
                value: 'Male',
            },
            
            {
                label: 'F',
                value: 'Female',
            }
      ];
    }
    onGenderChange(event: any) {
      if(this.selectedGender!=undefined) 
        console.log('Selected gender:', this.selectedGender.value);
}
    isLoggedIn(): void {
      this.isClicked = !this.isClicked;
      console.log("bool value: " + this.isClicked);
      if(this.isClicked==true) {
        this.route.navigate(['auth/login']);
      }
    }

    register(): void {
      if(this.value0 && this.value1 && this.value2 && this.selectedGender) {
        console.log("Registering with values:", this.value0, this.value1, this.value2, this.selectedGender.value);
      this.authService.authRegister(this.value0, this.value1, this.value2, this.selectedGender.value)
        .subscribe({
          next: (response) => {
            console.log('Registration successful:', response);
          },
          error: (error) => {
            console.error('Registration failed:', error);
            // Handle registration error
          }
        });
    }
  }
}
