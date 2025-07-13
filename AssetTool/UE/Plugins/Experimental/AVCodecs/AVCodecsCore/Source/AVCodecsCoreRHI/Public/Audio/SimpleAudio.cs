namespace AssetTool
{
    [JsonAsset("SimpleAudioHelper")]
    public class USimpleAudioHelper : USimpleAVHelper
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}