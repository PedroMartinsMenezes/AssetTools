namespace AssetTool
{
    [JsonAsset("MovieGraphInputNode")]
    public class UMovieGraphInputNode : UMovieGraphNode
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}