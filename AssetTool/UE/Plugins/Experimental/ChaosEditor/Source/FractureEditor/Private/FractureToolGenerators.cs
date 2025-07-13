namespace AssetTool
{
    [JsonAsset("FractureToolGenerateAsset")]
    public class UFractureToolGenerateAsset : UFractureActionTool
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("GeometryCollectionResetSettings")]
    public class UGeometryCollectionResetSettings : UFractureToolSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("FractureToolResetAsset")]
    public class UFractureToolResetAsset : UFractureModalTool
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}