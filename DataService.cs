using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace saf_demo
{
    public class DataService
    {
        public List< DataPlanDTO> GetDataPlans()
        {
            List<DataPlanDTO> List = new List<DataPlanDTO>(){
           new DataPlanDTO() {Id=1,PlanDescription="20 MBS",Price=5, Plans=Plans.Daily},
           new DataPlanDTO() {Id=2,PlanDescription="50 MBS",Price=50, Plans=Plans.Daily},
           new DataPlanDTO() {Id=3,PlanDescription="100 MBS",Price=60, Plans=Plans.Daily},
           new DataPlanDTO() {Id=4,PlanDescription="200 MBS",Price=70, Plans=Plans.Weekly},
           new DataPlanDTO() {Id=5,PlanDescription="500 MBS",Price=100, Plans=Plans.Weekly},
           new DataPlanDTO() {Id=6,PlanDescription="1GB",Price=500, Plans=Plans.Monthly},
           new DataPlanDTO() {Id=7,PlanDescription="2 GB",Price=800, Plans=Plans.Monthly},


            };
            return List;
        }
    }
}