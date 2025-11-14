namespace AssetTool
{
    [JsonAsset("NDIMediaSettings")]
    public class UNDIMediaSettings : UDeveloperSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}