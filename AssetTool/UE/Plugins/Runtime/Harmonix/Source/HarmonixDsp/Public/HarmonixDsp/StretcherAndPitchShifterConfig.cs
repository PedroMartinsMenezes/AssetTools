namespace AssetTool
{
    [JsonAsset("StretcherAndPitchShifterConfig")]
    public class UStretcherAndPitchShifterConfig : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}