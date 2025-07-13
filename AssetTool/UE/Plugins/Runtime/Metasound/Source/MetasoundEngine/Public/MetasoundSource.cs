namespace AssetTool
{
    [JsonAsset("MetaSoundSource")]
    public class UMetaSoundSource : USoundWaveProcedural
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}