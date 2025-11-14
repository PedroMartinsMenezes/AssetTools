namespace AssetTool
{
    [JsonAsset("MetaSoundSource")]
    public class UMetaSoundSource : USoundWaveProcedural
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}