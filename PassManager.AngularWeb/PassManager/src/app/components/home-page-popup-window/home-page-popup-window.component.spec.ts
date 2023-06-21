import { ComponentFixture, TestBed } from '@angular/core/testing';

import { HomePagePopupWindowComponent } from './home-page-popup-window.component';

describe('HomePagePopupWindowComponent', () => {
  let component: HomePagePopupWindowComponent;
  let fixture: ComponentFixture<HomePagePopupWindowComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ HomePagePopupWindowComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(HomePagePopupWindowComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
