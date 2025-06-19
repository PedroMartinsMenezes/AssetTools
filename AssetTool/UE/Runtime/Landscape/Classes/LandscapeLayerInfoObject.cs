namespace AssetTool
{
    [JsonAsset("LandscapeLayerInfoObject")]
    public class ULandscapeLayerInfoObject : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}