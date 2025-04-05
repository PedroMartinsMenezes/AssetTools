namespace AssetTool
{
    [JsonAsset("PaperTerrainSplineComponent")]
    public class UPaperTerrainSplineComponent : USplineComponent
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}