namespace AssetTool
{
    [JsonAsset("MixedRealityCaptureBillboard")]
    public class UMixedRealityCaptureBillboard : UMaterialBillboardComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MrcProjectionActor")]
    public class AMrcProjectionActor : AActor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}