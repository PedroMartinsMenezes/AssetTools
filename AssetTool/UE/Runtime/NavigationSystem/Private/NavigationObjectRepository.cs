namespace AssetTool
{
    [JsonAsset("NavigationObjectRepository")]
    public class UNavigationObjectRepository : UWorldSubsystem
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}