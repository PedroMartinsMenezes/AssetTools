namespace AssetTool
{
    [JsonAsset("MovieGraphScriptBase")]
    public class UMovieGraphScriptBase : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MovieGraphExecuteScriptNode")]
    public class UMovieGraphExecuteScriptNode : UMovieGraphSettingNode
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}