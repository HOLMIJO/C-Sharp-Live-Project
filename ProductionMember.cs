using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;

namespace TheatreCMS3.Areas.Prod.Models
{
    public partial class ProductionMember
    {
        public ProductionMember() { }

        public int ProductionMemberId { get; set; }
        public string Name { get; set; }
        public int? YearJoined { get; set; }
        public Position MainRole { get; set; }
        public string Bio { get; set; }
        public byte[] Photo { get; set; }
        public bool CurrentMember { get; set; }
        public string Character { get; set; }
        public int? CastYearLeft { get; set; }
        public int? DebutYearLeft { get; set; }
    }

    public enum PositionEnum
    {
        Actor,
        Director,
        Technician,
        StageManager,
        Other
    }
}