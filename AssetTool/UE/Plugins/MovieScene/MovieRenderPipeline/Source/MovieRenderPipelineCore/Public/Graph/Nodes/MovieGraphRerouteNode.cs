namespace AssetTool
{
    [JsonAsset("MovieGraphRerouteNode")]
    public class UMovieGraphRerouteNode : UMovieGraphSettingNode
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}