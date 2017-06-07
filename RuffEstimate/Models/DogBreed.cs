namespace RuffEstimate.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DogBreed
    {
        public DogBreed()
        {
            DogCharacteristics = new HashSet<DogCharacteristic>();
        }

        public int id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(200)]
        public string Description { get; set; }

        [StringLength(255)]
        public string Photo { get; set; }

        public string Appearance { get; set; }

        public int? SizeID { get; set; }

        public virtual BreedSize BreedSize { get; set; }

        public virtual ICollection<DogCharacteristic> DogCharacteristics { get; set; }
    }
}
