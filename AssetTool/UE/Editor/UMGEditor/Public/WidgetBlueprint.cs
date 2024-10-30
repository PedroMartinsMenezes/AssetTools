namespace AssetTool
{
    [JsonAsset("WidgetBlueprint")]
    public class UWidgetBlueprint : UBaseWidgetBlueprint
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}