namespace AssetTool
{
    [JsonAsset("SimpleVideoHelper")]
    public class USimpleVideoHelper : USimpleAVHelper
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}