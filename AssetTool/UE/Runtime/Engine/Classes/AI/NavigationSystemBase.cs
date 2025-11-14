namespace AssetTool
{
    [JsonAsset("NavigationSystemBase")]
    public class UNavigationSystemBase : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}