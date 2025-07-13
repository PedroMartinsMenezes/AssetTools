namespace AssetTool
{
    [JsonAsset("WaveTableBankFactory")]
    public class UWaveTableBankFactory : UFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}