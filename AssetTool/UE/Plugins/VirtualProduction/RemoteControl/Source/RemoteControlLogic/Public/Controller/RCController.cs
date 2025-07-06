namespace AssetTool
{
    [JsonAsset("RCController")]
    public class URCController : URCVirtualPropertyInContainer
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}