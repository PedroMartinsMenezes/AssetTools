namespace AssetTool
{
    [JsonAsset("VertexColorBaseBrushOpProps")]
    public class UVertexColorBaseBrushOpProps : UMeshSculptBrushOpProps
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("VertexColorPaintBrushOpProps")]
    public class UVertexColorPaintBrushOpProps : UVertexColorBaseBrushOpProps
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("VertexColorSoftenBrushOpProps")]
    public class UVertexColorSoftenBrushOpProps : UVertexColorBaseBrushOpProps
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("VertexColorSmoothBrushOpProps")]
    public class UVertexColorSmoothBrushOpProps : UVertexColorBaseBrushOpProps
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}