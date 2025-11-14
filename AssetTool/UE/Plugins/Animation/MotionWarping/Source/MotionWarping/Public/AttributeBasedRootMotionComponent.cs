namespace AssetTool
{
    [JsonAsset("AttributeBasedRootMotionComponent")]
    public class UAttributeBasedRootMotionComponent : UActorComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}