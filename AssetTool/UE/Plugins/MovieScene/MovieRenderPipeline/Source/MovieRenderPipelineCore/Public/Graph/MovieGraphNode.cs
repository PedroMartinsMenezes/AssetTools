namespace AssetTool
{
    [JsonAsset("MovieGraphNode")]
    public class UMovieGraphNode : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MovieGraphSettingNode")]
    public class UMovieGraphSettingNode : UMovieGraphNode
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}