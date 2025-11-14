namespace AssetTool
{
    [JsonAsset("FractureSliceSettings")]
    public class UFractureSliceSettings : UFractureToolSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("FractureToolSlice")]
    public class UFractureToolSlice : UFractureToolCutterBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}