namespace AssetTool
{
    [JsonAsset("OpenColorIOSettings")]
    public class UOpenColorIOSettings : UDeveloperSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}