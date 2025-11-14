namespace AssetTool
{
    [JsonAsset("PCGGraphAuthoringTestHelperSettings")]
    public class UPCGGraphAuthoringTestHelperSettings : UPCGSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}