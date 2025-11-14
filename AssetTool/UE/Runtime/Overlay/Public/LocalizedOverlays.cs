namespace AssetTool
{
    [JsonAsset("LocalizedOverlays")]
    public class ULocalizedOverlays : UOverlays
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}