namespace AssetTool
{
    [JsonAsset("ControlRigComponent")]
    public class UControlRigComponent : UPrimitiveComponent
    {
        [Location("void UControlRigComponent::Serialize(FArchive& Ar)")]
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}