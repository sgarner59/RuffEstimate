namespace RuffEstimate.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DogCharacteristic
    {
        public int id { get; set; }

        public int BreedID { get; set; }

        public bool ApartmentLiving { get; set; }

        public bool AloneOK { get; set; }

        public bool NoviceOwnerOK { get; set; }

        public bool FriendlyFamily { get; set; }

        public bool FriendlyKids { get; set; }

        public bool FriendlyStrangers { get; set; }

        public bool FriendlyDogs { get; set; }

        public bool SizeLarge { get; set; }

        public bool Sheds { get; set; }

        public bool EasyGroom { get; set; }

        public bool Drools { get; set; }

        public bool BarksHowls { get; set; }

        public bool WeightGainHigh { get; set; }

        public bool Intelligent { get; set; }

        public bool EasyTrain { get; set; }

        public bool WandersHigh { get; set; }

        public bool HighEnergy { get; set; }

        public bool IntensityHigh { get; set; }

        public bool SensitivityHigh { get; set; }

        public bool ColdWeatherOK { get; set; }

        public bool HotWeaterOK { get; set; }

        public bool Playfullness { get; set; }

        public bool ExerciseHigh { get; set; }

        public bool PreyDrive { get; set; }

        public virtual DogBreed DogBreed { get; set; }
    }
}
