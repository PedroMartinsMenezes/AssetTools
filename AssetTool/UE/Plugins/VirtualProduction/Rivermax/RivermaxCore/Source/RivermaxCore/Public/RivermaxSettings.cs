namespace AssetTool
{
    [JsonAsset("RivermaxSettings")]
    public class URivermaxSettings : UDeveloperSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}