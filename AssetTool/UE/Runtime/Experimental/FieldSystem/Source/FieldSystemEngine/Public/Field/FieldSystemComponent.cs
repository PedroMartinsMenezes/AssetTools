namespace AssetTool
{
    [JsonAsset("FieldSystemComponent")]
    public class UFieldSystemComponent : UPrimitiveComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}