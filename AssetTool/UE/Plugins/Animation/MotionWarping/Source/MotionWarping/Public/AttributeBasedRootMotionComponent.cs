namespace AssetTool
{
    [JsonAsset("AttributeBasedRootMotionComponent")]
    public class UAttributeBasedRootMotionComponent : UActorComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}