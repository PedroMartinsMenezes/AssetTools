namespace AssetTool
{
    [JsonAsset("InflateBrushOpProps")]
    public class UInflateBrushOpProps : UMeshSculptBrushOpProps
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}