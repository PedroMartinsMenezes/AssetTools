namespace AssetTool
{
    [JsonAsset("PaperTerrainSplineComponent")]
    public class UPaperTerrainSplineComponent : USplineComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}