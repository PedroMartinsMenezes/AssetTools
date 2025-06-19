namespace AssetTool
{
    [JsonAsset("BillboardComponent")]
    public class UBillboardComponent : UPrimitiveComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}