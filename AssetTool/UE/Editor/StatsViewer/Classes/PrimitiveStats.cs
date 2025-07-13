namespace AssetTool
{
    [JsonAsset("PrimitiveStats")]
    public class UPrimitiveStats : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}