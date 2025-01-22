using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class MatricDTO
    {
        public string MatricsId { get; set; }
        public string UserId { get; set; }
        public string Name { get; set; }
        public float Weight { get; set; }
        public int BloodPressure { get; set; }
        public int BloodTemperature { get; set; }
        public float BloodSugarLevel { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
