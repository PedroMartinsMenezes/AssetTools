namespace AssetTool
{
    [JsonAsset("MovieGraphNode")]
    public class UMovieGraphNode : UObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MovieGraphSettingNode")]
    public class UMovieGraphSettingNode : UMovieGraphNode
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}