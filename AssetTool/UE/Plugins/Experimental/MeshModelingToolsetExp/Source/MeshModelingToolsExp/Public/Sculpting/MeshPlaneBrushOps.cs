namespace AssetTool
{
    [JsonAsset("BasePlaneBrushOpProps")]
    public class UBasePlaneBrushOpProps : UMeshSculptBrushOpProps
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PlaneBrushOpProps")]
    public class UPlaneBrushOpProps : UBasePlaneBrushOpProps
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ViewAlignedPlaneBrushOpProps")]
    public class UViewAlignedPlaneBrushOpProps : UBasePlaneBrushOpProps
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("FixedPlaneBrushOpProps")]
    public class UFixedPlaneBrushOpProps : UBasePlaneBrushOpProps
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}