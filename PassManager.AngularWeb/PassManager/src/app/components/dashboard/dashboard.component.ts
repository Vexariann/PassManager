import { Component } from '@angular/core';
import { PasswordDTO } from 'app/interfaces/password-dto';
import { HttpServiceService } from 'app/services/http-service.service';
import { Observable, map } from 'rxjs';

@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrls: ['./dashboard.component.scss']
})

export class DashboardComponent {

  results: Array<PasswordDTO> = [];
  showPopup: Boolean = false;

  constructor(private httpService: HttpServiceService) { }

  ngOnInit(): void {
    const userId: number = parseInt(sessionStorage.getItem("UserId") || "0");
    this.httpService.getPasswordsByUserId(userId).subscribe(x => this.results = x)
  }

  showAddPassword() {
    this.showPopupWindow();
  }

  showPopupWindow() {
    this.showPopup = true;
  }

  hidePopupWindow() {
    this.showPopup = false;
  }

}