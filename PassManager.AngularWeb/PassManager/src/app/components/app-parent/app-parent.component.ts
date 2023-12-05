import { Component, Injectable, Input } from '@angular/core';
import { MatGridList } from '@angular/material/grid-list';

enum windows {
  Dashboard,
  Profile,
  Generate,
  Settings,
}

@Injectable({
  providedIn: 'root'
})

@Component({
  selector: 'app-app-parent',
  templateUrl: './app-parent.component.html',
  styleUrls: ['./app-parent.component.scss']
})

export class AppParentComponent {
  currentYear: number = new Date().getFullYear();

  //windowState: number = 0;
  enum: typeof windows = windows;
  currentWindow: number = windows.Dashboard;
  username: String = sessionStorage.getItem("Username") || "Undefined";
  //profilePicture: String = "Test123";

  @Input() profilePicture : String = "test123";
  
  DisplayImage(Base64String: any)
  {
      //console.log("In DisplayImage:" + Base64String.username);
      this.profilePicture = "data:image/png;base64," + Base64String.username;
  }

  showDashboard()
  {
      this.currentWindow = windows.Dashboard;
  }

  showProfile()
  {
    this.currentWindow = windows.Profile
  }

  showGenerate()
  {
    this.currentWindow = windows.Generate
  }

  showSettings()
  {
    this.currentWindow = windows.Settings
  }
}
