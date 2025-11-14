namespace AssetTool
{
    [JsonAsset("MovieGraphLinearTimeStep")]
    public class UMovieGraphLinearTimeStep : UMovieGraphCoreTimeStep
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}