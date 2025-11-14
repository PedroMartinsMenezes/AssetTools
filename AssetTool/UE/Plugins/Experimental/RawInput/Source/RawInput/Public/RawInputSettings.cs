namespace AssetTool
{
    [JsonAsset("RawInputSettings")]
    public class URawInputSettings : UDeveloperSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}