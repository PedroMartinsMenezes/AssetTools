namespace AssetTool
{
    [JsonAsset("MovieGraphLinearTimeStep")]
    public class UMovieGraphLinearTimeStep : UMovieGraphCoreTimeStep
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}