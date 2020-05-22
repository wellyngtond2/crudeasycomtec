import { Component, OnInit } from "@angular/core";
import { TalentBaseService } from "../services/talent-base.service";

@Component({
  selector: "app-talent-base",
  templateUrl: "./talent-base.component.html",
  styleUrls: ["./talent-base.component.css"],
})
export class TalentBaseComponent implements OnInit {
  constructor(private talentBaseService: TalentBaseService) {}

  ngOnInit() {}
}
