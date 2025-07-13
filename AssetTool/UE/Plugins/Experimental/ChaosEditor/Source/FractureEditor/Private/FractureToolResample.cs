namespace AssetTool
{
    [JsonAsset("FractureResampleSettings")]
    public class UFractureResampleSettings : UFractureToolSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("FractureToolResample")]
    public class UFractureToolResample : UFractureToolCutterBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}