namespace AssetTool
{
    [JsonAsset("XRDeviceVisualizationComponent")]
    public class UXRDeviceVisualizationComponent : UStaticMeshComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}