namespace AssetTool
{
    [JsonAsset("BaseWidgetBlueprint")]
    public class UBaseWidgetBlueprint : UUserWidgetBlueprint
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}