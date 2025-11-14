namespace AssetTool
{
    [JsonAsset("RCController")]
    public class URCController : URCVirtualPropertyInContainer
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}