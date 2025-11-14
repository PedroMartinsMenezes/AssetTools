namespace AssetTool
{
    [JsonAsset("InflateBrushOpProps")]
    public class UInflateBrushOpProps : UMeshSculptBrushOpProps
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}