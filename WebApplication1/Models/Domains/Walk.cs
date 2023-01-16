namespace WebApplication1.Models.Domains
{
    public class Walk
    {
        public Guid Id { get; set; }
        public string name{ get; set; }
        public double Length { get; set; }
        public Guid RegionId{ get; set; }
        public Guid WalkDifficultyId{ get; set; }
        
        //Navigation Property

        public Region Region { get; set; }

        public WalkDifficulty WalkDifficulty { get; set; }
    }
}
