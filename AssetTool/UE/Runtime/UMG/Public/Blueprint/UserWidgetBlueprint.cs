namespace AssetTool
{
    [JsonAsset("UserWidgetBlueprint")]
    public class UUserWidgetBlueprint : UBlueprint
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}