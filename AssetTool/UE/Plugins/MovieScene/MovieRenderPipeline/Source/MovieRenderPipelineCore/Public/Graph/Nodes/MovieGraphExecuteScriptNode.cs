namespace AssetTool
{
    [JsonAsset("MovieGraphScriptBase")]
    public class UMovieGraphScriptBase : UObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MovieGraphExecuteScriptNode")]
    public class UMovieGraphExecuteScriptNode : UMovieGraphSettingNode
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}