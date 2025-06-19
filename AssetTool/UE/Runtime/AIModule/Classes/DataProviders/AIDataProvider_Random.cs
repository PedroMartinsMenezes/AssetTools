namespace AssetTool
{
    [JsonAsset("AIDataProvider_Random")]
    public class UAIDataProvider_Random : UAIDataProvider_QueryParams
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}