namespace AssetTool
{
    [JsonAsset("PacketLimitTest_Oodle")]
    public class UPacketLimitTest_Oodle : UPacketLimitTest
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}