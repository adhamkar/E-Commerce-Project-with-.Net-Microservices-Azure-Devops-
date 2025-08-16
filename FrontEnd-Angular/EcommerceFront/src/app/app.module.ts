import { NgModule } from '@angular/core';
import { BrowserModule, provideClientHydration } from '@angular/platform-browser';
import { Component, OnInit } from '@angular/core';
import { MenubarModule } from 'primeng/menubar';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { NZ_ICONS } from 'ng-zorro-antd/icon';
import { MenuFoldOutline, MenuUnfoldOutline, MailOutline, AppstoreOutline, SettingOutline } from '@ant-design/icons-angular/icons';
import {BrowserAnimationsModule} from '@angular/platform-browser/animations';
import { ButtonModule } from 'primeng/button';
import { RouterModule } from '@angular/router';
import { HomeComponent } from './Components/Pages/home/home.component';
import { UsersComponent } from './Components/Pages/users/users.component';
import { ProductsComponent } from './Components/Pages/products/products.component';
import { ContactUsComponent } from './Components/Pages/contact-us/contact-us.component';
import { NavBarComponent } from './Components/nav-bar/nav-bar.component';
import { LoginComponent } from './Components/Auth/login/login.component';
import { RegisterComponent } from './Components/Auth/register/register.component';
import { FloatLabelModule } from "primeng/floatlabel"
import { InputTextModule } from 'primeng/inputtext';
import { FormsModule } from '@angular/forms';
import { CommonModule } from '@angular/common';
import { PasswordModule } from 'primeng/password';
import {HttpClientModule} from "@angular/common/http";
import { CascadeSelectModule } from 'primeng/cascadeselect';


@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    UsersComponent,
    ProductsComponent,
    ContactUsComponent,
    NavBarComponent,
    LoginComponent,
    RegisterComponent,  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    MenubarModule,
    ButtonModule,
    RouterModule,
    FloatLabelModule,
    InputTextModule,
    FormsModule,
    CommonModule,
    PasswordModule,
    HttpClientModule,
    CascadeSelectModule
  ],
  providers: [
    { provide: NZ_ICONS,
      useValue: [MenuFoldOutline, MenuUnfoldOutline, MailOutline, AppstoreOutline, SettingOutline]
    },
    provideClientHydration(),
   
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
