namespace AssetTool
{
    [JsonAsset("CurveEditorFilterBase")]
    public class UCurveEditorFilterBase : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}