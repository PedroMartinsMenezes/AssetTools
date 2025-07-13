namespace AssetTool
{
    [JsonAsset("DMXProtocolSettings")]
    public class UDMXProtocolSettings : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}