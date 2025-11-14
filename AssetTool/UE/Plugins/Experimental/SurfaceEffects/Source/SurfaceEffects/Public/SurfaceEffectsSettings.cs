namespace AssetTool
{
    [JsonAsset("SurfaceEffectsSettings")]
    public class USurfaceEffectsSettings : UDeveloperSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}