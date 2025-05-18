namespace AssetTool
{
    [JsonAsset("BrushBaseProperties")]
    public class UBrushBaseProperties : UInteractiveToolPropertySet
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("BrushAdjusterInputBehavior")]
    public class UBrushAdjusterInputBehavior : UAnyButtonInputBehavior
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("BaseBrushTool")]
    public class UBaseBrushTool : UMeshSurfacePointTool
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}