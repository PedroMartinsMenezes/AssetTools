namespace AssetTool
{
    [JsonAsset("MovieGraphStartEndConsoleCommands")]
    public class UMovieGraphStartEndConsoleCommands : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MovieGraphSetStartEndConsoleCommandsNode")]
    public class UMovieGraphSetStartEndConsoleCommandsNode : UMovieGraphSettingNode
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}