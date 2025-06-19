namespace AssetTool
{
    [JsonAsset("CubeBuilder")]
    public class UCubeBuilder : UEditorBrushBuilder
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}