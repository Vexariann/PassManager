import { Component, Injectable, Input } from '@angular/core';
import { MatGridList } from '@angular/material/grid-list';
import { HttpServiceService } from 'app/services/http-service.service';

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

  constructor(private httpService: HttpServiceService) {}

  currentYear: number = new Date().getFullYear();

  //windowState: number = 0;
  enum: typeof windows = windows;
  currentWindow: number = windows.Dashboard;
  username: String = sessionStorage.getItem("Username") || "Undefined";
  //profilePicture: String = "Test123";

  @Input() profilePicture : String = "test123";
  
  ngOnInit(): void
  {
    this.DisplayImage();
  }

  DisplayImage()
  {
    this.httpService.getProfilePictureByUsername(sessionStorage.getItem("Username") || "Undefined").subscribe(res => {this.profilePicture = "data:image/png;base64," + res.username; console.log(res);});
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

  logOut()
  {
    sessionStorage.setItem("Username", "")
    sessionStorage.setItem("LoggedIn", "false")
    window.location.reload();
  }
}
