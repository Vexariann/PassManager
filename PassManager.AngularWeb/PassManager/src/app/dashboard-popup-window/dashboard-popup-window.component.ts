import { Component } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { DashboardComponent } from 'app/components/dashboard/dashboard.component';
import { PasswordDTO } from 'app/interfaces/password-dto';
import { HttpServiceService } from 'app/services/http-service.service';

@Component({
  selector: 'app-dashboard-popup-window',
  templateUrl: './dashboard-popup-window.component.html',
  styleUrls: ['./dashboard-popup-window.component.scss']
})
export class DashboardPopupWindowComponent {

  constructor(private dashboard: DashboardComponent, private httpService: HttpServiceService) { }

  hidePopupWindow() {
    this.dashboard.hidePopupWindow();
  }

  submitPasswordForm = new FormGroup({
    Website: new FormControl('', [Validators.required]),
    Password: new FormControl('', [Validators.required]),
    Thumbnail: new FormControl('', [Validators.required]),
    Tag: new FormControl('', [Validators.required])
    //UserID: new FormControl('', [Validators.required])
  })

  submitPassword() {
    const errorHTML = window.document.getElementById("errorText") as HTMLElement;
    let password = this.submitPasswordForm.value as PasswordDTO;
    password.userID = parseInt("" + sessionStorage.getItem("UserId"));
    password.thumbnail = "placeholder.png"
    password.tag = "General"

    this.httpService.createPassword(password).subscribe({
      next: (res) => {
        console.log(res);
        window.location.reload();
      }, error: (err) => { console.log(err.error); }
    });
  }

}
