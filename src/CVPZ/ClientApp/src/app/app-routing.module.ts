import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { AuthorizationGuard } from './authorization.guard';
import { HomeComponent } from './home/home.component';
import { AboutComponent } from './about/about.component';
import { JournalListComponent } from './journal-list/journal-list.component';
import { AutoLoginComponent } from './auto-login/auto-login.component';
import { ForbiddenComponent } from './forbidden/forbidden.component';
import { UnauthorizedComponent } from './unauthorized/unauthorized.component';


const routes: Routes = [
  { path: '', redirectTo: '/home', pathMatch: 'full' },
  { path: 'home', component: HomeComponent },
  { path: 'journal', component: JournalListComponent, canActivate: [AuthorizationGuard] },
  { path: 'autologin', component: AutoLoginComponent },
  { path: 'forbidden', component: ForbiddenComponent, canActivate: [AuthorizationGuard] },
  { path: 'unauthorized', component: UnauthorizedComponent },
  { path: 'about', component: AboutComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
