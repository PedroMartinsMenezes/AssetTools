namespace AssetTool
{
    [JsonAsset("IpNetDriver")]
    public class UIpNetDriver : UNetDriver
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}