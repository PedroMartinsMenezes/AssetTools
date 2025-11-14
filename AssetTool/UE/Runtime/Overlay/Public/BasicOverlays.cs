namespace AssetTool
{
    [JsonAsset("BasicOverlays")]
    public class UBasicOverlays : UOverlays
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}