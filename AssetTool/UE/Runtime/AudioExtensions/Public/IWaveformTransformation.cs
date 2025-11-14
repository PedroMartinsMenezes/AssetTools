namespace AssetTool
{
    [JsonAsset("WaveformTransformationBase")]
    public class UWaveformTransformationBase : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("WaveformTransformationChain")]
    public class UWaveformTransformationChain : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}