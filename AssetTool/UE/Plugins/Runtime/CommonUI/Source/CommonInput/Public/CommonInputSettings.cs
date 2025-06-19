namespace AssetTool
{
    [JsonAsset("CommonInputSettings")]
    public class UCommonInputSettings : UDeveloperSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}