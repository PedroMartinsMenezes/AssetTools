namespace AssetTool
{
    [JsonAsset("AvaMediaSettings")]
    public class UAvaMediaSettings : UDeveloperSettings
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}