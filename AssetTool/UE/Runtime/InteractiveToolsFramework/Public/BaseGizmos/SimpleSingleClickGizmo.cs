namespace AssetTool
{
    [JsonAsset("SimpleSingleClickGizmo")]
    public class USimpleSingleClickGizmo : UInteractiveGizmo
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}