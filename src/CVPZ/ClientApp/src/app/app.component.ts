import { Component, OnDestroy, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { OidcSecurityService } from 'angular-auth-oidc-client';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {
  constructor(public oidcSecurityService: OidcSecurityService, private router: Router) {}

  ngOnInit() {
    this.oidcSecurityService
        .checkAuth()
        .subscribe((auth) => console.log('is authenticated', auth));
  }

  login() {
      this.oidcSecurityService.authorize();
  }

  logout() {
      this.oidcSecurityService.logoff();
  }

  private navigateToStoredEndpoint() {
      const path = this.read('redirect');

      if (this.router.url === path) {
          return;
      }

      if (path.toString().includes('/unauthorized')) {
          this.router.navigate(['/']);
      } else {
          this.router.navigate([path]);
      }
  }

  private read(key: string): any {
      const data = localStorage.getItem(key);
      if (data) {
          return JSON.parse(data);
      }

      return;
  }

  private write(key: string, value: any): void {
      localStorage.setItem(key, JSON.stringify(value));
  }
}
