using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF
{
    public class HealthGoal
    {
        [Key]
        public string  GoalId { get; set; }
        public string UserId { get; set; }
        public string MatricType { get; set; }
        public float TargetValue { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public float Progress { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
