namespace AssetTool
{
    [JsonAsset("WebAPIModelBase")]
    public class UWebAPIModelBase : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("WebAPISchema")]
    public class UWebAPISchema : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}