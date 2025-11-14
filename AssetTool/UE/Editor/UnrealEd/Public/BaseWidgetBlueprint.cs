namespace AssetTool
{
    [JsonAsset("BaseWidgetBlueprint")]
    public class UBaseWidgetBlueprint : UUserWidgetBlueprint
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}