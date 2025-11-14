namespace AssetTool
{
    [JsonAsset("FractureResampleSettings")]
    public class UFractureResampleSettings : UFractureToolSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("FractureToolResample")]
    public class UFractureToolResample : UFractureToolCutterBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}