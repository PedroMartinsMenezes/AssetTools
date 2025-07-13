namespace AssetTool
{
    [JsonAsset("PacketLimitTest")]
    public class UPacketLimitTest : UClientUnitTest
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}