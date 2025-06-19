namespace AssetTool
{
    [JsonAsset("ConeBuilder")]
    public class UConeBuilder : UEditorBrushBuilder
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}