namespace AssetTool
{
    [JsonAsset("MassClientBubbleInfoBase")]
    public class AMassClientBubbleInfoBase : AInfo
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}