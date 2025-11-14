namespace AssetTool
{
    [JsonAsset("PaintBrushSettings")]
    public class UPaintBrushSettings : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MeshPaintSettings")]
    public class UMeshPaintSettings : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}