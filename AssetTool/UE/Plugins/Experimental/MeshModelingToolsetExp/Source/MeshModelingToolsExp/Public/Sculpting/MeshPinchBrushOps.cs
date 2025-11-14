namespace AssetTool
{
    [JsonAsset("PinchBrushOpProps")]
    public class UPinchBrushOpProps : UMeshSculptBrushOpProps
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}