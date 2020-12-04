import { Component } from '@angular/core';
import { OidcSecurityService } from 'angular-auth-oidc-client';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {
  title = 'CVPZ';

  constructor(public oidcSecurityService: OidcSecurityService) {}
 
  ngOnInit() {
      this.oidcSecurityService.checkAuth().subscribe((auth) => console.log('is authenticated', auth));
  }
}
