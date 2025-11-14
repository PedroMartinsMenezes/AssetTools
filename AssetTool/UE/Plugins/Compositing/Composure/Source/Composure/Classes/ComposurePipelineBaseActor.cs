namespace AssetTool
{
    [JsonAsset("ComposurePipelineBaseActor")]
    public class AComposurePipelineBaseActor : AActor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}