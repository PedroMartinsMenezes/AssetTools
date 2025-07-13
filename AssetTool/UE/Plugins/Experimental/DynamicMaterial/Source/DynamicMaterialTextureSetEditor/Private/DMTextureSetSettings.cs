namespace AssetTool
{
    [JsonAsset("DMTextureSetSettings")]
    public class UDMTextureSetSettings : UDeveloperSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}