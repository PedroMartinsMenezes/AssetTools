namespace AssetTool
{
    [JsonAsset("AvaViewportSettings")]
    public class UAvaViewportSettings : UDeveloperSettings
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}