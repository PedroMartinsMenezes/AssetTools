namespace AssetTool
{
    [JsonAsset("ClothPainterSettings")]
    public class UClothPainterSettings : UMeshPaintSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}