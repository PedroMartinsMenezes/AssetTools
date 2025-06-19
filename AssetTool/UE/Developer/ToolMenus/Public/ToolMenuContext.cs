namespace AssetTool
{
    [JsonAsset("ToolMenuContextBase")]
    public class UToolMenuContextBase : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("SlateTabManagerContext")]
    public class USlateTabManagerContext : UToolMenuContextBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}