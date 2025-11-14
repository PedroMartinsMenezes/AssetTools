namespace AssetTool
{
    [JsonAsset("BillboardComponent")]
    public class UBillboardComponent : UPrimitiveComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}