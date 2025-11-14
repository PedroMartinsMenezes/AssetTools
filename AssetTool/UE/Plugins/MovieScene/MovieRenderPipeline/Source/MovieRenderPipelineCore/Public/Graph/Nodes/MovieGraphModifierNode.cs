namespace AssetTool
{
    [JsonAsset("MovieGraphMergeableModifierContainer")]
    public class UMovieGraphMergeableModifierContainer : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MovieGraphModifierNode")]
    public class UMovieGraphModifierNode : UMovieGraphSettingNode
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}