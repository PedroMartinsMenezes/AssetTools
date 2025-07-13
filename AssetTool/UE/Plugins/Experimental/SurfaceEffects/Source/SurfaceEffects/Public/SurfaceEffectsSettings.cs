namespace AssetTool
{
    [JsonAsset("SurfaceEffectsSettings")]
    public class USurfaceEffectsSettings : UDeveloperSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}