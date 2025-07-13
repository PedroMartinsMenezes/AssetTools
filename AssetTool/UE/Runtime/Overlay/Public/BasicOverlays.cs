namespace AssetTool
{
    [JsonAsset("BasicOverlays")]
    public class UBasicOverlays : UOverlays
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}