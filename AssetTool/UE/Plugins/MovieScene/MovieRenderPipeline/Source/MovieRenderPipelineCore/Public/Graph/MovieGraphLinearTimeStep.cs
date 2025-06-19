namespace AssetTool
{
    [JsonAsset("MovieGraphLinearTimeStep")]
    public class UMovieGraphLinearTimeStep : UMovieGraphCoreTimeStep
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}