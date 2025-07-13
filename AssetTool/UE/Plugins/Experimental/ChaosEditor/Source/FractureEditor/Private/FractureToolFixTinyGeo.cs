namespace AssetTool
{
    [JsonAsset("FractureTinyGeoSettings")]
    public class UFractureTinyGeoSettings : UFractureToolSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("FractureToolFixTinyGeo")]
    public class UFractureToolFixTinyGeo : UFractureToolCutterBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}