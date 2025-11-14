namespace AssetTool
{
    [JsonAsset("MonoWaveTableSynthPreset")]
    public class UMonoWaveTableSynthPreset : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("SynthComponentMonoWaveTable")]
    public class USynthComponentMonoWaveTable : USynthComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}