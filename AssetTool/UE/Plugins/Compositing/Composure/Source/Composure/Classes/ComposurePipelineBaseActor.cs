namespace AssetTool
{
    [JsonAsset("ComposurePipelineBaseActor")]
    public class AComposurePipelineBaseActor : AActor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}