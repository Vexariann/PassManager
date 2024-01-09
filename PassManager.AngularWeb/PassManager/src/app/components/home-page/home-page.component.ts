import { Component } from '@angular/core';
import { HttpServiceService } from 'app/services/http-service.service';
import { HomePagePopupWindowComponent } from '../home-page-popup-window/home-page-popup-window.component';

@Component({
  selector: 'app-home-page',
  templateUrl: './home-page.component.html',
  styleUrls: ['./home-page.component.scss']
})
export class HomePageComponent {

    // this line breaks code!
    // circular dependency
    constructor(private httpService: HttpServiceService) {}

    currentYear: number = new Date().getFullYear();
  
    ngOnInit(): void
    {
      this.loggedIn = (this.loggedInString === 'true');
    }

    loggedIn: Boolean = false;
    showPopup: Boolean = false;
    popupWindowName: String = "";
    profilePictureBase64: String = "";
    loggedInString: String = sessionStorage.getItem("LoggedIn") || "false";

    logIn()
    {
      this.loggedIn = true;
    }

    showPopupWindow()
    {
      this.showPopup = true;
    }

    hidePopupWindow()
    {
      this.showPopup = false;
    }

    setRegister()
    {
      //this.homePagePopup.showRegister();
      this.popupWindowName = "Register";
      this.showPopupWindow();
    }

    setLogin()
    {
      //this.homePagePopup.showLogin();
      this.popupWindowName = "Login";
      this.showPopupWindow();
    }
}
