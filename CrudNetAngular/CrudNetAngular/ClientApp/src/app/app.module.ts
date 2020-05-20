import { BrowserModule } from "@angular/platform-browser";
import { NgModule } from "@angular/core";
import { FormsModule } from "@angular/forms";
import { HttpClientModule, HTTP_INTERCEPTORS } from "@angular/common/http";
import AppRouting from "./app-routing.module";

import { AppComponent } from "./app.component";
import { DeveloperComponent } from "./developer/developer.component";
import { KnowledgeComponent } from "./knowledge/knowledge.component";
import { OccupationComponent } from "./occupation/occupation.component";
import { TalentBaseComponent } from "./talent-base/talent-base.component";
import { BrowserAnimationsModule } from "@angular/platform-browser/animations";
import { MaterialModule } from "./material/material.module";
@NgModule({
  declarations: [
    AppComponent,
    DeveloperComponent,
    KnowledgeComponent,
    OccupationComponent,
    TalentBaseComponent,
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: "ng-cli-universal" }),
    HttpClientModule,
    FormsModule,
    AppRouting,
    BrowserAnimationsModule,
    MaterialModule,
  ],
  providers: [],
  bootstrap: [AppComponent],
})
export class AppModule {}
