namespace AssetTool
{
    [JsonAsset("WaterBodyMeshComponent")]
    public class UWaterBodyMeshComponent : UStaticMeshComponent
    {
        [Location("UWaterBodyMeshComponent::UWaterBodyMeshComponent(const FObjectInitializer& ObjectInitializer)")]
        public UWaterBodyMeshComponent()
        {
            bComputeBoundsOnceForGame = true;
        }

        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}