namespace AssetTool
{
    [JsonAsset("ControlRigComponent")]
    public class UControlRigComponent : UPrimitiveComponent
    {
        [Location("void UControlRigComponent::Serialize(FArchive& Ar)")]
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}