namespace AssetTool
{
    [JsonAsset("PaperTerrainSplineComponent")]
    public class UPaperTerrainSplineComponent : USplineComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}