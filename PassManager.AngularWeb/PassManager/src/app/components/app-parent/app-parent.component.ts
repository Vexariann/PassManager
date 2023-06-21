import { Component } from '@angular/core';
import { MatGridList } from '@angular/material/grid-list';

enum windowState {
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
  enum: typeof windowState = windowState;
  currentWindow: number = windowState.Dashboard;

  showDashboard()
  {
      this.currentWindow = windowState.Dashboard;
  }

  showProfile()
  {
    this.currentWindow = windowState.Profile
  }

  showGenerate()
  {
    this.currentWindow = windowState.Generate
  }

  showSettings()
  {
    this.currentWindow = windowState.Settings
  }
}
