namespace AssetTool
{
    [JsonAsset("ClothPainterSettings")]
    public class UClothPainterSettings : UMeshPaintSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}