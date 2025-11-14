namespace AssetTool
{
    [JsonAsset("PaperTerrainComponent")]
    public class UPaperTerrainComponent : UPrimitiveComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}