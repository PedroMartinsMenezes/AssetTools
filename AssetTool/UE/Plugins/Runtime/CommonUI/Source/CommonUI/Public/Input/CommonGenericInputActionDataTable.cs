namespace AssetTool
{
    [JsonAsset("CommonGenericInputActionDataTable")]
    public class UCommonGenericInputActionDataTable : UDataTable
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("CommonInputActionDataProcessor")]
    public class UCommonInputActionDataProcessor : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}