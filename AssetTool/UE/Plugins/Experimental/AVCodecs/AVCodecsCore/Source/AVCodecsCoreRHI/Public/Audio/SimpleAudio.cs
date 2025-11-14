namespace AssetTool
{
    [JsonAsset("SimpleAudioHelper")]
    public class USimpleAudioHelper : USimpleAVHelper
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}