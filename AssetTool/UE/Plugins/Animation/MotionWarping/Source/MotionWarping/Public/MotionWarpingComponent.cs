namespace AssetTool
{
    [JsonAsset("MotionWarpingUtilities")]
    public class UMotionWarpingUtilities : UBlueprintFunctionLibrary
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MotionWarpingComponent")]
    public class UMotionWarpingComponent : UActorComponent
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}