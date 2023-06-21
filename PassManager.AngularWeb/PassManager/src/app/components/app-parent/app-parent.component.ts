import { Component } from '@angular/core';
import { MatGridList } from '@angular/material/grid-list';

enum windows {
  Dashboard,
  Profile,
  Generate,
  Settings,
}

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
