namespace AssetTool
{
    [JsonAsset("UsdTransactor")]
    public class UUsdTransactor : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}