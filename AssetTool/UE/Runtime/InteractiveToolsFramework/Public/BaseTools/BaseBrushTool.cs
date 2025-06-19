namespace AssetTool
{
    [JsonAsset("BrushBaseProperties")]
    public class UBrushBaseProperties : UInteractiveToolPropertySet
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("BrushAdjusterInputBehavior")]
    public class UBrushAdjusterInputBehavior : UAnyButtonInputBehavior
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("BaseBrushTool")]
    public class UBaseBrushTool : UMeshSurfacePointTool
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}