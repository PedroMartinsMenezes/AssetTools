namespace AssetTool
{
    [JsonAsset("DoubleChannelKeyProxy")]
    public class UDoubleChannelKeyProxy : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}