namespace AssetTool
{
    [JsonAsset("MassClientBubbleInfoBase")]
    public class AMassClientBubbleInfoBase : AInfo
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}