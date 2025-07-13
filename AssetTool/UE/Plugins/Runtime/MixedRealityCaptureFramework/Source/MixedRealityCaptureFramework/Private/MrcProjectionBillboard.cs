namespace AssetTool
{
    [JsonAsset("MixedRealityCaptureBillboard")]
    public class UMixedRealityCaptureBillboard : UMaterialBillboardComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MrcProjectionActor")]
    public class AMrcProjectionActor : AActor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}