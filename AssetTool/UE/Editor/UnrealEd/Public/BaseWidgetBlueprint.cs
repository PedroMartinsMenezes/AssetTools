namespace AssetTool
{
    [JsonAsset("BaseWidgetBlueprint")]
    public class UBaseWidgetBlueprint : UUserWidgetBlueprint
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}