import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import {MatGridListModule} from '@angular/material/grid-list';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HomePageComponent } from './components/home-page/home-page.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { DashboardComponent } from './components/dashboard/dashboard.component';
import { AppParentComponent } from './components/app-parent/app-parent.component';
import { ProfileComponent } from './components/profile/profile.component';

@NgModule({
  declarations: [
    AppComponent,
    HomePageComponent,
    DashboardComponent,
    AppParentComponent,
    ProfileComponent
  ],
  imports: [
    BrowserModule,
    MatGridListModule,
    AppRoutingModule,
    BrowserAnimationsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
