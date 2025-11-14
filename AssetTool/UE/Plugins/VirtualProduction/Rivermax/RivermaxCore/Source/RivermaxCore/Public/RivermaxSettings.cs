namespace AssetTool
{
    [JsonAsset("RivermaxSettings")]
    public class URivermaxSettings : UDeveloperSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}