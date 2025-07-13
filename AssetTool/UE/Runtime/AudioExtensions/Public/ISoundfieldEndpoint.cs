namespace AssetTool
{
    [JsonAsset("SoundfieldEndpointSettingsBase")]
    public class USoundfieldEndpointSettingsBase : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}