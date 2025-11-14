namespace AssetTool
{
    [JsonAsset("CubeBuilder")]
    public class UCubeBuilder : UEditorBrushBuilder
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}