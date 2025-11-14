namespace AssetTool
{
    [JsonAsset("MovieGraphInputNode")]
    public class UMovieGraphInputNode : UMovieGraphNode
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}