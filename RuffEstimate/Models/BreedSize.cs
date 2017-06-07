namespace RuffEstimate.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BreedSize")]
    public partial class BreedSize
    {
        public BreedSize()
        {
            DogBreeds = new HashSet<DogBreed>();
        }

        public int ID { get; set; }

        [Required]
        [StringLength(20)]
        public string SizeName { get; set; }

        public virtual ICollection<DogBreed> DogBreeds { get; set; }
    }
}
