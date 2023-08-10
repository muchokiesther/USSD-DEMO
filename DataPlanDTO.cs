using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace saf_demo
{
    public enum Plans // created an enum for the plans we wanted 
    {
        // CAN ACCES ENUMS VIA INTERGERES TOO
        Daily=1,
        Weekly=2,
        Monthly=3  
    }
    public class DataPlanDTO
    {
        public int Id { get; set; }
        public Plans Plans { get; set; }
        public string PlanDescription { get; set; } =string.Empty;

        public int Price { get; set; }
    }
}