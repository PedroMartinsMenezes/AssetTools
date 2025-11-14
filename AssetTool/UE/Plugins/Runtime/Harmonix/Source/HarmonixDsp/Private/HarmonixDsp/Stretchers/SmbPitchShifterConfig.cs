namespace AssetTool
{
    [JsonAsset("SmbPitchShifterConfig")]
    public class USmbPitchShifterConfig : UStretcherAndPitchShifterConfig
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}