namespace AssetTool
{
    [JsonAsset("SimpleSingleClickGizmo")]
    public class USimpleSingleClickGizmo : UInteractiveGizmo
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}