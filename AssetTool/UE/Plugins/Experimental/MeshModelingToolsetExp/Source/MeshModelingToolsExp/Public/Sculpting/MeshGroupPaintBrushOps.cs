namespace AssetTool
{
    [JsonAsset("GroupEraseBrushOpProps")]
    public class UGroupEraseBrushOpProps : UMeshSculptBrushOpProps
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("GroupPaintBrushOpProps")]
    public class UGroupPaintBrushOpProps : UMeshSculptBrushOpProps
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}