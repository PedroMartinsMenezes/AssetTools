namespace AssetTool
{
    [JsonAsset("SoundfieldEndpointSettingsBase")]
    public class USoundfieldEndpointSettingsBase : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}