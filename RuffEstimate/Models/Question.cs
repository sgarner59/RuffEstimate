namespace RuffEstimate.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Question
    {
        [Key]
        public int id { get; set; }

        [Required]
        [StringLength(200)]
        public string QuestionString { get; set; }

        public int? Order { get; set; }

        [StringLength(20)]
        public string Characteristic { get; set; }
    }
}
