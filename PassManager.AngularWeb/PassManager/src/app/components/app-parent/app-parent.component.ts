import { Component } from '@angular/core';
import { MatGridList } from '@angular/material/grid-list';

@Component({
  selector: 'app-app-parent',
  templateUrl: './app-parent.component.html',
  styleUrls: ['./app-parent.component.scss']
})
export class AppParentComponent {
  currentYear: number = new Date().getFullYear();

  windowState: number = 0;

  showDashboard()
  {
      this.windowState = 0;
  }

  showProfile()
  {
    this.windowState = 1;
  }
}
