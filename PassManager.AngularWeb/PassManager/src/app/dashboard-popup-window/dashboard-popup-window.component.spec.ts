import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DashboardPopupWindowComponent } from './dashboard-popup-window.component';

describe('DashboardPopupWindowComponent', () => {
  let component: DashboardPopupWindowComponent;
  let fixture: ComponentFixture<DashboardPopupWindowComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ DashboardPopupWindowComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(DashboardPopupWindowComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
