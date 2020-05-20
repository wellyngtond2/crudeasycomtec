import { Component, OnInit } from "@angular/core";

@Component({
  selector: "app-knowledge",
  templateUrl: "./knowledge.component.html",
  styleUrls: ["./knowledge.component.css"],
})
export class KnowledgeComponent implements OnInit {
  Knowledges: Array<IKnowledge> = [
    { Id: "1", Description: "C#" },
    { Id: "2", Description: "React" },
    { Id: "3", Description: "Angular" },
  ];

  constructor() {}

  ngOnInit() {}
}

interface IKnowledge {
  Id: String;
  Description: String;
}
