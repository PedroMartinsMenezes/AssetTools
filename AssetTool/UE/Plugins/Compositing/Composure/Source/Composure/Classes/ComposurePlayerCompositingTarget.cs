namespace AssetTool
{
    [JsonAsset("ComposurePlayerCompositingTarget")]
    public class UComposurePlayerCompositingTarget : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ComposureCompositingTargetComponent")]
    public class UComposureCompositingTargetComponent : UActorComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}