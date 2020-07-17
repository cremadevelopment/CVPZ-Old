import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { HttpClientModule } from '@angular/common/http';

import { MatButtonModule } from '@angular/material/button';
import { MatIconModule } from '@angular/material/icon';
import { MatToolbarModule } from '@angular/material/toolbar';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { JournalListComponent } from './journal-list/journal-list.component';
import { HomeComponent } from './home/home.component';
import { AboutComponent } from './about/about.component';
import { JournalAddComponent } from './journal-add/journal-add.component';

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    JournalListComponent,
    HomeComponent,
    AboutComponent,
    JournalAddComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    BrowserAnimationsModule,
    MatButtonModule,
    MatIconModule,
    MatToolbarModule,
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
