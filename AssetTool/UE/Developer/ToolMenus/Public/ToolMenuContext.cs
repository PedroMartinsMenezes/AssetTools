namespace AssetTool
{
    [JsonAsset("ToolMenuContextBase")]
    public class UToolMenuContextBase : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("SlateTabManagerContext")]
    public class USlateTabManagerContext : UToolMenuContextBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}