namespace AssetTool
{
    [JsonAsset("WidgetBlueprint")]
    public class UWidgetBlueprint : UBaseWidgetBlueprint
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}