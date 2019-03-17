
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProjectStatus.Models
{
    public class ProjectDetail
    {
        [Key]
        public int ProjectId { get; set; }

        public string ProjectTitle { get; set; }

        public string ProjectParentTitle { get; set; }

        public long ProjectManagerID { get; set; }

        public string ProjectManagerName { get; set; }

        public string ProjectEndDate { get; set; }

        public int ResourceCount { get; set; }

        public ICollection<ProjectStatusDetail> ProjectStatusDetail { get; set; }

    }
}
