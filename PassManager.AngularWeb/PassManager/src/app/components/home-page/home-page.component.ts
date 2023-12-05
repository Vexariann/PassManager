import { Component } from '@angular/core';
import { HomePagePopupWindowComponent } from '../home-page-popup-window/home-page-popup-window.component';

@Component({
  selector: 'app-home-page',
  templateUrl: './home-page.component.html',
  styleUrls: ['./home-page.component.scss']
})
export class HomePageComponent {

    // this line breaks code!
    // circular dependency
    //constructor(private homePagePopup: HomePagePopupWindowComponent) {}

    currentYear: number = new Date().getFullYear();
  
    ngOnInit(): void{}

    //NOTE: delete loader service, is not necessary

    loggedIn: Boolean = false;
    showPopup: Boolean = false;
    popupWindowName: String = "";
    profilePictureBase64: String = "";

    SetProfilePictureBase64String(Base64String : any)
    {
      this.profilePictureBase64 = "data:image/png;base64," + Base64String.username;
    }

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
