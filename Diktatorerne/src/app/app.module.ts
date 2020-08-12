import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { DiktatorFormComponent } from './diktator-form/diktator-form.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { DictatorTableComponent } from './dictator-table/dictator-table.component';

@NgModule({
  declarations: [
    AppComponent,
    DiktatorFormComponent,
    DictatorTableComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    ReactiveFormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
