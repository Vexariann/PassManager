import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';

import {MatGridListModule} from '@angular/material/grid-list';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HomePageComponent } from './components/home-page/home-page.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { DashboardComponent } from './components/dashboard/dashboard.component';
import { AppParentComponent } from './components/app-parent/app-parent.component';
import { ProfileComponent } from './components/profile/profile.component';
import { SettingsComponent } from './components/settings/settings.component';
import { HomePagePopupWindowComponent } from './components/home-page-popup-window/home-page-popup-window.component';
import { DashboardPopupWindowComponent } from './dashboard-popup-window/dashboard-popup-window.component';
import { GenerateComponent } from './generate/generate.component';

@NgModule({
  declarations: [
    AppComponent,
    HomePageComponent,
    DashboardComponent,
    AppParentComponent,
    ProfileComponent,
    SettingsComponent,
    HomePagePopupWindowComponent,
    DashboardPopupWindowComponent,
    GenerateComponent
  ],
  imports: [
    BrowserModule,
    MatGridListModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    ReactiveFormsModule,
    HttpClientModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
