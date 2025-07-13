namespace AssetTool
{
    [JsonAsset("PaintBrushSettings")]
    public class UPaintBrushSettings : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MeshPaintSettings")]
    public class UMeshPaintSettings : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}