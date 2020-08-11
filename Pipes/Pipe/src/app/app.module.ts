import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { MorsecodePipe } from './morsecode.pipe';
import { Md5Pipe } from './md5.pipe';

@NgModule({
  declarations: [
    AppComponent,
    MorsecodePipe,
    Md5Pipe
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
