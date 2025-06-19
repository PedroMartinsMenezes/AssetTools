namespace AssetTool
{
    [JsonAsset("MovieGraphMergeableModifierContainer")]
    public class UMovieGraphMergeableModifierContainer : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MovieGraphModifierNode")]
    public class UMovieGraphModifierNode : UMovieGraphSettingNode
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}