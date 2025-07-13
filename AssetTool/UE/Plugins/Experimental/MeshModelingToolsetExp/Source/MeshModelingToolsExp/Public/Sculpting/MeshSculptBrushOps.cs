namespace AssetTool
{
    [JsonAsset("StandardSculptBrushOpProps")]
    public class UStandardSculptBrushOpProps : UMeshSculptBrushOpProps
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ViewAlignedSculptBrushOpProps")]
    public class UViewAlignedSculptBrushOpProps : UMeshSculptBrushOpProps
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("SculptMaxBrushOpProps")]
    public class USculptMaxBrushOpProps : UMeshSculptBrushOpProps
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}