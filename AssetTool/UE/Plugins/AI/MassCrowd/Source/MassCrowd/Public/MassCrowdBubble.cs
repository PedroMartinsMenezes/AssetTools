namespace AssetTool
{
    [JsonAsset("MassCrowdClientBubbleInfo")]
    public class AMassCrowdClientBubbleInfo : AMassClientBubbleInfoBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}