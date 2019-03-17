
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectStatus.Models
{
    public class ProjectStatusDetail
    {
        [Key]
        public int StatusID { get; set; }

        public ProjectDetail ProjectDetail { get; set; }

        [ForeignKey("ProjectDetail")]    
        public int ProjectID { get; set; }

        public string ProjectTitle { get; set; }

        public string CurrentStage { get; set; }

        public bool DeliveryEscalation { get; set; }

        public string DeliverEscalationDetails { get; set; }

        public bool ResourcingEscalation { get; set; }

        public string ResourcingEscalationDetails { get; set; }

        public string CurrentStatus { get; set; }

        public string ProjectEndDate { get; set; }

        public int RampDownCount { get; set; }

        public string RampDownTechStack { get; set; }
        
    }

    

   
}
