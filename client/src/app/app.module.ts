import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { HttpClientModule } from '@angular/common/http';
import { CoreModule } from './core/core.module';
import { AngularMaterialModule } from './shared/angular-material-module';
import { ShopModule } from './shop/shop.module';
import { HomeModule } from './home/home.module';
import { BasketModule } from './basket/basket.module';

@NgModule({
  declarations: [
    AppComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    AngularMaterialModule,
    HttpClientModule,
    CoreModule,
    ShopModule,
    HomeModule,
    BasketModule,
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
