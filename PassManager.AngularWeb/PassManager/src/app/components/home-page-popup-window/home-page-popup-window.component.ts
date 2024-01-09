import { Component } from '@angular/core';
import { HomePageComponent } from '../home-page/home-page.component';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { User } from '../../interfaces/user';
import { HttpServiceService } from 'app/services/http-service.service';
import { DomSanitizer, SafeUrl } from '@angular/platform-browser';
import { AppParentComponent } from '../app-parent/app-parent.component';

enum popups {
  Register,
  Login,
}

@Component({
  selector: 'app-home-page-popup-window',
  templateUrl: './home-page-popup-window.component.html',
  styleUrls: ['./home-page-popup-window.component.scss']
})
export class HomePagePopupWindowComponent {

  constructor(private homePage: HomePageComponent, private httpService: HttpServiceService, private sanitizer: DomSanitizer) { }

  enum: typeof popups = popups;
  currentPopup: popups = popups.Login;
  popupWindowName: String = "";

  selectedFile?: any;
  encodedFile?: String;

  ngOnInit(): void {
    this.popupWindowName = this.homePage.popupWindowName;
    if (this.popupWindowName == "Register") {
      this.currentPopup = popups.Register;
    }
    else if (this.popupWindowName == "Login") {
      this.currentPopup = popups.Login;
    }
  }

  hidePopupWindow() {
    this.homePage.hidePopupWindow();
  }

  logIn() {
    this.homePage.logIn();
  }

  showRegister() {
    this.currentPopup = popups.Register;
  }

  showLogin() {
    this.currentPopup = popups.Login;
  }

  registerUserForm = new FormGroup({
    Username: new FormControl('', [Validators.required]),
    Password: new FormControl('', [Validators.required]),
    ProfilePicture: new FormControl('', [Validators.required])
  })

  loginUserForm = new FormGroup({
    Username: new FormControl('', [Validators.required]),
    Password: new FormControl('', [Validators.required]),
  })

  public createUser() {
    const errorHTML = window.document.getElementById("errorText") as HTMLElement;

    //check if the repeat password matches the password
    const firstPassword = this.registerUserForm.value.Password;
    const secondPassword = (<HTMLInputElement>document.getElementById("RepeatPassword")).value;
    if (firstPassword == secondPassword) {
      //first upload user
      let user = this.registerUserForm.value as User;
      this.httpService.createUser(user).subscribe({
        next: (res) => {
          console.log(res);
          //then upload image
          this.httpService.uploadImage(this.encodedFile!, this.registerUserForm.value.Username!, this.selectedFile.name).subscribe({
            next: (res) => {
              console.log(res);
              sessionStorage.setItem("Username", this.registerUserForm.value.Username || "undefined")
              sessionStorage.setItem("LoggedIn", "true")
              this.logIn();
            }, error: (err) => { console.log(err.error); }
          });
          console.log(this.encodedFile);
        }, error: (err) => { console.log(err.error); errorHTML.innerHTML = err.error.message }
      });

    } else {
      errorHTML.innerHTML = "The repeated password does not match!";
    }
  }

  previewImage: string | SafeUrl = "../../../assets/images/profilepictures/!Standard.jpg";

  updatePreviewImage(event: any) {
    const file = event.target.files[0]
    this.selectedFile = file;

    this.convertImageToBase64();

    this.previewImage = this.sanitizer.bypassSecurityTrustUrl(
      window.URL.createObjectURL(file)
    );
  }

  convertImageToBase64() {
    var reader = new FileReader();
    var binaryString = reader.readAsDataURL(this.selectedFile!);
    reader.onload = () => {
      var output = reader.result;
      this.encodedFile = output as String;
      this.encodedFile = this.encodedFile?.substring(this.encodedFile.lastIndexOf(',') + 1);
    }
  }

  public loginUser() {
    const errorHTML = window.document.getElementById("errorText") as HTMLElement;

    let user = this.loginUserForm.value as User;
    this.httpService.loginUser(user).subscribe({
      next: (res) => {
        //console.log(res);
        sessionStorage.setItem("LoggedIn", "true")
        //debugger;
        sessionStorage.setItem("Username", res.user.username)
        sessionStorage.setItem("UserId", res.user.id)
        this.logIn();
      }, error: (err) => { console.log(err.error); errorHTML.innerHTML = err.error.message }
    });
  }
}
