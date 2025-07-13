namespace AssetTool
{
    [JsonAsset("StretcherAndPitchShifterConfig")]
    public class UStretcherAndPitchShifterConfig : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}