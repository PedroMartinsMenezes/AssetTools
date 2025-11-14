namespace AssetTool
{
    [JsonAsset("UsdTransactor")]
    public class UUsdTransactor : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}