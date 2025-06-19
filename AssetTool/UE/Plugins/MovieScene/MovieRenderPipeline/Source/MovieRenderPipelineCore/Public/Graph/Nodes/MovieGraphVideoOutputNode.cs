namespace AssetTool
{
    [JsonAsset("MovieGraphVideoOutputNode")]
    public class UMovieGraphVideoOutputNode : UMovieGraphFileOutputNode
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}