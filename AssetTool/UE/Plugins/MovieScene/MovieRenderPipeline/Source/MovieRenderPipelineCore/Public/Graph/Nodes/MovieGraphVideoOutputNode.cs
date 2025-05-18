namespace AssetTool
{
    [JsonAsset("MovieGraphVideoOutputNode")]
    public class UMovieGraphVideoOutputNode : UMovieGraphFileOutputNode
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}