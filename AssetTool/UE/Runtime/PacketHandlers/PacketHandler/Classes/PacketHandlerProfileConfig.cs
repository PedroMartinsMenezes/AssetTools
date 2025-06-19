namespace AssetTool
{
    [JsonAsset("PacketHandlerProfileConfig")]
    public class UPacketHandlerProfileConfig : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}