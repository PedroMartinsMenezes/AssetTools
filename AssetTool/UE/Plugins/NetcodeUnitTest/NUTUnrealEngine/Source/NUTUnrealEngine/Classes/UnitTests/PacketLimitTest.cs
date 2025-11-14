namespace AssetTool
{
    [JsonAsset("PacketLimitTest")]
    public class UPacketLimitTest : UClientUnitTest
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}