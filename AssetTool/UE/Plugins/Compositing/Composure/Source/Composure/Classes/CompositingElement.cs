namespace AssetTool
{
    [JsonAsset("CompositingElement")]
    public class ACompositingElement : AComposurePipelineBaseActor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}