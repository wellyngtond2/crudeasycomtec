import { NgModule } from "@angular/core";
import {
  MatButtonModule,
  MatIconModule,
  MatTabsModule,
  MatInputModule,
  MatFormFieldModule,
  MatCardModule,
  MatCheckboxModule,
  MatRadioModule,
} from "@angular/material";

const MaterialComponents = [
  MatButtonModule,
  MatIconModule,
  MatTabsModule,
  MatInputModule,
  MatFormFieldModule,
  MatCardModule,
  MatCheckboxModule,
  MatRadioModule,
];

@NgModule({
  imports: [MaterialComponents],
  exports: [MaterialComponents],
})
export class MaterialModule {}
