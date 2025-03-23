namespace AssetTool
{
    [JsonAsset("CommonInputSettings")]
    public class UCommonInputSettings : UDeveloperSettings
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}