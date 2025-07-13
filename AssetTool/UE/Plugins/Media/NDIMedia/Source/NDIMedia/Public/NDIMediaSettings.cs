namespace AssetTool
{
    [JsonAsset("NDIMediaSettings")]
    public class UNDIMediaSettings : UDeveloperSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}