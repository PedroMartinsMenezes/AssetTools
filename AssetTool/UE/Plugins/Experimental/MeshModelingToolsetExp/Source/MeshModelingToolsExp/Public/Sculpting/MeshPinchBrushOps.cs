namespace AssetTool
{
    [JsonAsset("PinchBrushOpProps")]
    public class UPinchBrushOpProps : UMeshSculptBrushOpProps
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}