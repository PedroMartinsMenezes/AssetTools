namespace AssetTool
{
    [JsonAsset("CurveEditorFilterBase")]
    public class UCurveEditorFilterBase : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}