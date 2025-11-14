namespace AssetTool
{
    [JsonAsset("MovieGraphBranchNode")]
    public class UMovieGraphBranchNode : UMovieGraphNode
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}