namespace AssetTool
{
    [JsonAsset("DummyRenderLayerOnlyNode")]
    public class UDEPRECATED_DummyRenderLayerOnlyNode : UMovieGraphSettingNode
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}