namespace AssetTool
{
    [JsonAsset("SimpleVideoHelper")]
    public class USimpleVideoHelper : USimpleAVHelper
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}