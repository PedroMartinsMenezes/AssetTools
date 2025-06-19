namespace AssetTool
{
    [JsonAsset("PlanarReflectionComponent")]
    public class UPlanarReflectionComponent : USceneCaptureComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}