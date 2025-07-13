namespace AssetTool
{
    [JsonAsset("WebAPIProperty")]
    public class UWebAPIProperty : UWebAPIModelBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("WebAPIModel")]
    public class UWebAPIModel : UWebAPIModelBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}