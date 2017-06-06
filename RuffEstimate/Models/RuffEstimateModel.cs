namespace RuffEstimate.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class RuffEstimateModel : DbContext
    {
        public RuffEstimateModel()
            : base("name=RuffEstModel")
        {
        }

        public virtual DbSet<BreedSize> BreedSizes { get; set; }
        public virtual DbSet<DogBreed> DogBreeds { get; set; }
        public virtual DbSet<DogCharacteristic> DogCharacteristics { get; set; }
        public virtual DbSet<Question> Questions { get; set; }
        public virtual DbSet<UserQuestionAnswer> UserQuestionAnswers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BreedSize>()
                .HasMany(e => e.DogBreeds)
                .WithOptional(e => e.BreedSize)
                .HasForeignKey(e => e.SizeID);

            modelBuilder.Entity<DogBreed>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<DogBreed>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<DogBreed>()
                .HasMany(e => e.DogCharacteristics)
                .WithRequired(e => e.DogBreed)
                .HasForeignKey(e => e.BreedID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Question>()
                .Property(e => e.QuestionString)
                .IsUnicode(false);
        }
    }
}
