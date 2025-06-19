namespace AssetTool
{
    [JsonAsset("PaperTerrainComponent")]
    public class UPaperTerrainComponent : UPrimitiveComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}