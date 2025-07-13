namespace AssetTool
{
    [JsonAsset("SmartObjectSubsystemRenderingComponent")]
    public class USmartObjectSubsystemRenderingComponent : USmartObjectDebugRenderingComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("SmartObjectSubsystemRenderingActor")]
    public class ASmartObjectSubsystemRenderingActor : AActor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}