namespace AssetTool
{
    [JsonAsset("PaperTerrainComponent")]
    public class UPaperTerrainComponent : UPrimitiveComponent
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}