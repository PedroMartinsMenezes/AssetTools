namespace AssetTool
{
    [JsonAsset("NavigationSystemConfig")]
    public class UNavigationSystemConfig : UObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("NullNavSysConfig")]
    public class UNullNavSysConfig : UNavigationSystemConfig
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}