import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { AccountComponent } from './account/account.component';
import { ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { AdminDashboardComponent } from './admin-dashboard/admin-dashboard.component';
import { MemberDashboardComponent } from './member-dashboard/member-dashboard.component';
import { PmDashboardComponent } from './pm-dashboard/pm-dashboard.component';
import { AddNewUserComponent } from './add-new-user/add-new-user.component';
import { GetUsersComponent } from './get-users/get-users.component';
import { GetProjectsComponent } from './get-projects/get-projects.component';
import { AddNewProjectComponent } from './add-new-project/add-new-project.component';
import { AssignProjectComponent } from './assign-project/assign-project.component';
import { AssignTaskComponent } from './assign-task/assign-task.component';
import { AddCommentComponent } from './add-comment/add-comment.component';

@NgModule({
  declarations: [
    AppComponent,
    AccountComponent,
    AdminDashboardComponent,
    MemberDashboardComponent,
    PmDashboardComponent,
    AddNewUserComponent,
    GetUsersComponent,
    GetProjectsComponent,
    AddNewProjectComponent,
    AssignProjectComponent,
    AssignTaskComponent,
    AddCommentComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    ReactiveFormsModule,
    HttpClientModule
   
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
