import { Component,OnInit } from '@angular/core';
import { AuthService } from '../../../Services/Auth-Service/auth.service';
import {ActivatedRoute, Router} from "@angular/router";
@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrl: './login.component.css'
})
export class LoginComponent implements OnInit {
    isClicked: boolean = false;
    value1: string | undefined;

    constructor(private authService: AuthService,private route: Router) {}

    value2: string | undefined;
    ngOnInit() {
      console.log(this.isClicked)
    }
    isLoggedIn(): void {
      this.isClicked = !this.isClicked;
      console.log("bool value: " + this.isClicked);
      if(this.isClicked==true) {
        this.route.navigate(['/auth/register']);
      }
    }

    public login() {
      if (this.value1 && this.value2) {
        this.authService.authLogin(this.value1, this.value2).subscribe(
          (response) => {
            console.log("Login successful", response);
          },
          (error) => {
            console.error("Login failed", error);
            // Handle login failure here, e.g., show an error message
          }
        );
      } else {
        console.error("Email and password are required");
      }
    }
}
