namespace AssetTool
{
    [JsonAsset("TetrahedronBuilder")]
    public class UTetrahedronBuilder : UEditorBrushBuilder
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}