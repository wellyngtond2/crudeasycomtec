import { RouterModule, Routes } from "@angular/router";
import { DeveloperComponent } from "./developer/developer.component";
import { KnowledgeComponent } from "./knowledge/knowledge.component";
import { OccupationComponent } from "./occupation/occupation.component";
import { TalentBaseComponent } from "./talent-base/talent-base.component";
import { NgModule } from "@angular/core";

const routes: Routes = [
  { path: "", component: TalentBaseComponent, pathMatch: "full" },
  { path: "developer", component: DeveloperComponent },
  { path: "knowledge", component: KnowledgeComponent },
  { path: "occupation", component: OccupationComponent },
];

export default RouterModule.forRoot(routes);
