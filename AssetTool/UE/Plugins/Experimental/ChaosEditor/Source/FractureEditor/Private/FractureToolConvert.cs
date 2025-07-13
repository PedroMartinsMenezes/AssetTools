namespace AssetTool
{
    [JsonAsset("FractureConvertSettings")]
    public class UFractureConvertSettings : UFractureToolSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("FractureReimportSettings")]
    public class UFractureReimportSettings : UFractureToolSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("FractureToolConvert")]
    public class UFractureToolConvert : UFractureModalTool
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}