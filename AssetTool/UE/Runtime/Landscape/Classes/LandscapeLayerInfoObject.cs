namespace AssetTool
{
    [JsonAsset("LandscapeLayerInfoObject")]
    public class ULandscapeLayerInfoObject : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}