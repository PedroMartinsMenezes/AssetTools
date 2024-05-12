namespace AssetTool
{
    public class UDynamicBlueprintBinding : UObject
    {
        public new UDynamicBlueprintBinding Move(Transfer transfer) => (UDynamicBlueprintBinding)base.Move(transfer);
    }
}
