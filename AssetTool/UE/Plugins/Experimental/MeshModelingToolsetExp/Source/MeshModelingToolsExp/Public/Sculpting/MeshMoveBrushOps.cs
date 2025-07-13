namespace AssetTool
{
    [JsonAsset("MoveBrushOpProps")]
    public class UMoveBrushOpProps : UMeshSculptBrushOpProps
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}