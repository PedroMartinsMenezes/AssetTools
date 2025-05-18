namespace AssetTool
{
    [JsonAsset("MovieGraphMergeableModifierContainer")]
    public class UMovieGraphMergeableModifierContainer : UObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MovieGraphModifierNode")]
    public class UMovieGraphModifierNode : UMovieGraphSettingNode
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}