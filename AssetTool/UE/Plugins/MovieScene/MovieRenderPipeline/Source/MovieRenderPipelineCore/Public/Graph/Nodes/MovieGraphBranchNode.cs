namespace AssetTool
{
    [JsonAsset("MovieGraphBranchNode")]
    public class UMovieGraphBranchNode : UMovieGraphNode
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}