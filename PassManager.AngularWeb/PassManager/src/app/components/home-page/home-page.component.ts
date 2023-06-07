import { Component } from '@angular/core';

@Component({
  selector: 'app-home-page',
  templateUrl: './home-page.component.html',
  styleUrls: ['./home-page.component.scss']
})
export class HomePageComponent {
    currentYear: number = new Date().getFullYear();

    ngOnInit(): void{}

    //NOTE: delete loader service, is not necessary

    loggedIn: Boolean = false;

    hideComponent()
    {
      this.loggedIn = true;
      console.log("clicked");
    }
}
