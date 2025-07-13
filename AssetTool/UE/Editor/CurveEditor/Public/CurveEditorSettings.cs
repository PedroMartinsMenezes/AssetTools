namespace AssetTool
{
    [JsonAsset("CurveEditorSettings")]
    public class UCurveEditorSettings : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}