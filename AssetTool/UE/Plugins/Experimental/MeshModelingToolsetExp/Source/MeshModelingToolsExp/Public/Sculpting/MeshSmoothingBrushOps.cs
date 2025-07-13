namespace AssetTool
{
    [JsonAsset("BaseSmoothBrushOpProps")]
    public class UBaseSmoothBrushOpProps : UMeshSculptBrushOpProps
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("SmoothBrushOpProps")]
    public class USmoothBrushOpProps : UBaseSmoothBrushOpProps
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("SecondarySmoothBrushOpProps")]
    public class USecondarySmoothBrushOpProps : UBaseSmoothBrushOpProps
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("SmoothFillBrushOpProps")]
    public class USmoothFillBrushOpProps : UBaseSmoothBrushOpProps
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("FlattenBrushOpProps")]
    public class UFlattenBrushOpProps : UMeshSculptBrushOpProps
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("EraseBrushOpProps")]
    public class UEraseBrushOpProps : UMeshSculptBrushOpProps
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}