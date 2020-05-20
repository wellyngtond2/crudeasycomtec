import { Component, OnInit } from "@angular/core";

@Component({
  selector: "app-occupation",
  templateUrl: "./occupation.component.html",
  styleUrls: ["./occupation.component.css"],
})
export class OccupationComponent implements OnInit {
  Occupations: Array<IOccupation> = [
    { Id: "1", Description: "Up to 4 hours per day / Até 4 horas por dia" },
    { Id: "2", Description: "4 to 6 hours per day / De 4 á 6 horas por dia" },
    { Id: "3", Description: "6 to 8 hours per day /De 6 á 8 horas por dia" },
  ];
  constructor() {}

  ngOnInit() {}
}

interface IOccupation {
  Id: String;
  Description: String;
}
