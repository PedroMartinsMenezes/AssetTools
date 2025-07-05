namespace AssetTool
{
    [JsonAsset("SmbPitchShifterConfig")]
    public class USmbPitchShifterConfig : UStretcherAndPitchShifterConfig
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}