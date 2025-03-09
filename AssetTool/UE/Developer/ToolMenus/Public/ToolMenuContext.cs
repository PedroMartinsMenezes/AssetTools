namespace AssetTool
{
    [JsonAsset("ToolMenuContextBase")]
    public class UToolMenuContextBase : UObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("SlateTabManagerContext")]
    public class USlateTabManagerContext : UToolMenuContextBase
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}