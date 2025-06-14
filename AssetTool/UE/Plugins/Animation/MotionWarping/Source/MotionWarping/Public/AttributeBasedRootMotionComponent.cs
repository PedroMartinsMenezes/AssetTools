namespace AssetTool
{
    [JsonAsset("AttributeBasedRootMotionComponent")]
    public class UAttributeBasedRootMotionComponent : UActorComponent
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}