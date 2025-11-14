namespace AssetTool
{
    [JsonAsset("PlanarReflectionComponent")]
    public class UPlanarReflectionComponent : USceneCaptureComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}