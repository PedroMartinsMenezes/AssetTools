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

        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}