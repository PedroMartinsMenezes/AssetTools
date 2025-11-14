namespace AssetTool
{
    [JsonAsset("CurveEditorSettings")]
    public class UCurveEditorSettings : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}