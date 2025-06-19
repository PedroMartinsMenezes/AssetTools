namespace AssetTool
{
    [JsonAsset("AvaViewportSettings")]
    public class UAvaViewportSettings : UDeveloperSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}