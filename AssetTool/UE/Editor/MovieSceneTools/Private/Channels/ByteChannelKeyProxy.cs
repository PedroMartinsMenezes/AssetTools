namespace AssetTool
{
    [JsonAsset("ByteChannelKeyProxy")]
    public class UByteChannelKeyProxy : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}