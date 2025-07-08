namespace AssetTool
{
    [JsonAsset("XRDeviceVisualizationComponent")]
    public class UXRDeviceVisualizationComponent : UStaticMeshComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}