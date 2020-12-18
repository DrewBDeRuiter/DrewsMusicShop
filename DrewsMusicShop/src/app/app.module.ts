import { NgModule }      from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { AppRoutingModule } from './app-routing.module';
import { WelcomeComponent } from './Home/welcome.component';
import { HttpModule } from '@angular/http';

@NgModule({
  imports: [BrowserModule, AppRoutingModule, HttpModule ],
  declarations: [ AppComponent, WelcomeComponent ],
  bootstrap:    [ WelcomeComponent ]
})
export class AppModule { }
