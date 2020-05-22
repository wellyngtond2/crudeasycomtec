import { developerModel } from "src/app/developer/model/developer.model";
import { knowledgeModel } from "src/app/knowledge/model/knowledge.model";
import { occupationModel } from "src/app/occupation/model/occupation.model";

export interface talentBaseMode {
  id: string;
  KnowledgePlus: string;
  CrudLink: string;
  HourPrice: number;
  Developer: developerModel;
  Knowledges: knowledgeModel[];
  Occupations: occupationModel[];
}
