namespace AssetTool
{
    [JsonAsset("MassCrowdClientBubbleInfo")]
    public class AMassCrowdClientBubbleInfo : AMassClientBubbleInfoBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}