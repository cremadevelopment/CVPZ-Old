import { BrowserModule } from '@angular/platform-browser';
import { APP_INITIALIZER, NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { FormsModule } from '@angular/forms';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';

import { AuthModule, LogLevel, OidcConfigService } from 'angular-auth-oidc-client';

import { MatButtonModule } from '@angular/material/button';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatIconModule } from '@angular/material/icon';
import { MatInputModule } from '@angular/material/input';
import { MatListModule } from '@angular/material/list';
import { MatSliderModule } from '@angular/material/slider';
import { MatToolbarModule } from '@angular/material/toolbar';
import { MatMenuModule } from '@angular/material/menu';

import { AboutComponent } from './about/about.component';
import { HomeComponent } from './home/home.component';
import { JournalAddComponent } from './journal-add/journal-add.component';
import { JournalListComponent } from './journal-list/journal-list.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { AuthenticationComponent } from './authentication/authentication.component';
import { AuthInterceptor } from './auth.interceptor';
import { UnauthorizedComponent } from './unauthorized/unauthorized.component';
import { ProfileComponent } from './profile/profile.component';

export function configureAuth(oidcConfigService: OidcConfigService) {
  return () =>
    oidcConfigService.withConfig({
      stsServer: 'https://localhost:6001',
      redirectUrl: window.location.origin,
      postLogoutRedirectUri: window.location.origin,
      clientId: 'netAngularClient',
      scope: 'openid profile api1',
      responseType: 'code',
      silentRenew: true,
      silentRenewUrl: `${window.location.origin}/silent-renew.html`,
      logLevel: LogLevel.Debug,
    });
}

@NgModule({
  declarations: [
    AppComponent,
    AboutComponent,
    HomeComponent,
    JournalAddComponent,
    JournalListComponent,
    NavMenuComponent,
    AuthenticationComponent,
    UnauthorizedComponent,
    ProfileComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    AuthModule.forRoot(),
    FormsModule,
    HttpClientModule,
    BrowserAnimationsModule,
    MatButtonModule,
    MatFormFieldModule,
    MatIconModule,
    MatInputModule,
    MatListModule,
    MatSliderModule,
    MatToolbarModule,
    MatMenuModule,
  ],
  providers: [
    OidcConfigService,
    {
      provide: APP_INITIALIZER,
      useFactory: configureAuth,
      deps: [OidcConfigService],
      multi: true,
    },
    {
      provide: HTTP_INTERCEPTORS,
      useClass: AuthInterceptor,
      multi: true
    }
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
