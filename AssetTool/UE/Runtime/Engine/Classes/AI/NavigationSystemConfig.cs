namespace AssetTool
{
    [JsonAsset("NavigationSystemConfig")]
    public class UNavigationSystemConfig : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("NullNavSysConfig")]
    public class UNullNavSysConfig : UNavigationSystemConfig
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}