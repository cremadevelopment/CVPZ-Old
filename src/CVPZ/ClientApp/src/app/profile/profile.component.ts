import { Component, OnInit } from '@angular/core';
import { OidcClientNotification, OidcSecurityService, PublicConfiguration } from 'angular-auth-oidc-client';
import { Observable } from 'rxjs';

@Component({
  selector: 'app-profile',
  templateUrl: './profile.component.html',
  styleUrls: ['./profile.component.scss']
})
export class ProfileComponent implements OnInit {
  
  userData: any;
  checkSessionChanged: boolean;

  constructor(public oidcSecurityService: OidcSecurityService) { }

  ngOnInit(): void {
    this.oidcSecurityService.userData$.subscribe(ud => this.userData = ud );
    this.oidcSecurityService.checkSessionChanged$.subscribe(x => this.checkSessionChanged = x);
  }

  refreshSession() {
    this.oidcSecurityService.forceRefreshSession().subscribe((result) => console.log(result));
  }

}
