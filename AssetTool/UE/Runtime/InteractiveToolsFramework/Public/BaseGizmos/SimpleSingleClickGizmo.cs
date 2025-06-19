namespace AssetTool
{
    [JsonAsset("SimpleSingleClickGizmo")]
    public class USimpleSingleClickGizmo : UInteractiveGizmo
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}