namespace AssetTool
{
    [JsonAsset("PCGGraphAuthoringTestHelperSettings")]
    public class UPCGGraphAuthoringTestHelperSettings : UPCGSettings
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}