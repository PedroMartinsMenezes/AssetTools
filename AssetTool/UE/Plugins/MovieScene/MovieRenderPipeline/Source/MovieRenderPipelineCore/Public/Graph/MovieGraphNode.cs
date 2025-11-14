namespace AssetTool
{
    [JsonAsset("MovieGraphNode")]
    public class UMovieGraphNode : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MovieGraphSettingNode")]
    public class UMovieGraphSettingNode : UMovieGraphNode
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}