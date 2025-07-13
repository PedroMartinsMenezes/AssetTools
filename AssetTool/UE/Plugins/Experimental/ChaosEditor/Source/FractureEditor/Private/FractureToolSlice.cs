namespace AssetTool
{
    [JsonAsset("FractureSliceSettings")]
    public class UFractureSliceSettings : UFractureToolSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("FractureToolSlice")]
    public class UFractureToolSlice : UFractureToolCutterBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}