namespace AssetTool
{
    [JsonAsset("UserWidgetBlueprint")]
    public class UUserWidgetBlueprint : UBlueprint
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}