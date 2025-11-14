namespace AssetTool
{
    [JsonAsset("WidgetBlueprint")]
    public class UWidgetBlueprint : UBaseWidgetBlueprint
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}