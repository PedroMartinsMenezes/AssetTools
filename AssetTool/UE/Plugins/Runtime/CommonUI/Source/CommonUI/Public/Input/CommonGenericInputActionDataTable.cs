namespace AssetTool
{
    [JsonAsset("CommonGenericInputActionDataTable")]
    public class UCommonGenericInputActionDataTable : UDataTable
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("CommonInputActionDataProcessor")]
    public class UCommonInputActionDataProcessor : UObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}