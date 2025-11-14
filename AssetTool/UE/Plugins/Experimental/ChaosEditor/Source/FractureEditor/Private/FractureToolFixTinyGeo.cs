namespace AssetTool
{
    [JsonAsset("FractureTinyGeoSettings")]
    public class UFractureTinyGeoSettings : UFractureToolSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("FractureToolFixTinyGeo")]
    public class UFractureToolFixTinyGeo : UFractureToolCutterBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}