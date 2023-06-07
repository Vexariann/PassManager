import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class LoaderService {

  constructor() { }

  hidden: Boolean = false;

  hideComponent()
  {
    this.hidden = true;
    console.log("clicked");
  }
}
