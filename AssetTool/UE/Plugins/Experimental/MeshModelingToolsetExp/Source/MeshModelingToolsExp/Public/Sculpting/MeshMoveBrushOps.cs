namespace AssetTool
{
    [JsonAsset("MoveBrushOpProps")]
    public class UMoveBrushOpProps : UMeshSculptBrushOpProps
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}