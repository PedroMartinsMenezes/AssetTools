namespace AssetTool
{
    [JsonAsset("AvaMediaSettings")]
    public class UAvaMediaSettings : UDeveloperSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}