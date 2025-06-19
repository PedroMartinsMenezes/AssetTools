namespace AssetTool
{
    [JsonAsset("TetrahedronBuilder")]
    public class UTetrahedronBuilder : UEditorBrushBuilder
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}