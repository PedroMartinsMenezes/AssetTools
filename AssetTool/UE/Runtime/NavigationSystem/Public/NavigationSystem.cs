namespace AssetTool
{
    [JsonAsset("NavigationSystemV1")]
    public class UNavigationSystemV1 : UNavigationSystemBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("NavigationSystemModuleConfig")]
    public class UNavigationSystemModuleConfig : UNavigationSystemConfig
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}