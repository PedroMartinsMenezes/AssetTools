namespace AssetTool
{
    [JsonAsset("WaveformTransformationBase")]
    public class UWaveformTransformationBase : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("WaveformTransformationChain")]
    public class UWaveformTransformationChain : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}