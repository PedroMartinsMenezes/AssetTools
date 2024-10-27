namespace AssetTool
{
    [JsonAsset("BillboardComponent")]
    public class UBillboardComponent : UPrimitiveComponent
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}