namespace AssetTool
{
    [JsonAsset("CommonGenericInputActionDataTable")]
    public class UCommonGenericInputActionDataTable : UDataTable
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("CommonInputActionDataProcessor")]
    public class UCommonInputActionDataProcessor : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}