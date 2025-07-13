namespace AssetTool
{
    [JsonAsset("FieldSystemComponent")]
    public class UFieldSystemComponent : UPrimitiveComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}