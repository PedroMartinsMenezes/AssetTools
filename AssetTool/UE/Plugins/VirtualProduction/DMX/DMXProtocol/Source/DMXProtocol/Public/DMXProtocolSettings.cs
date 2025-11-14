namespace AssetTool
{
    [JsonAsset("DMXProtocolSettings")]
    public class UDMXProtocolSettings : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}