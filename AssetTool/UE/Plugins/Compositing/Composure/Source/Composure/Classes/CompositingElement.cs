namespace AssetTool
{
    [JsonAsset("CompositingElement")]
    public class ACompositingElement : AComposurePipelineBaseActor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}