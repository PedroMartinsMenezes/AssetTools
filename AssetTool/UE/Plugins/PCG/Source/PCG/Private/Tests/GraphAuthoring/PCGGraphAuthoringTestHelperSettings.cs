namespace AssetTool
{
    [JsonAsset("PCGGraphAuthoringTestHelperSettings")]
    public class UPCGGraphAuthoringTestHelperSettings : UPCGSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}