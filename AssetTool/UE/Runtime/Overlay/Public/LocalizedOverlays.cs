namespace AssetTool
{
    [JsonAsset("LocalizedOverlays")]
    public class ULocalizedOverlays : UOverlays
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}