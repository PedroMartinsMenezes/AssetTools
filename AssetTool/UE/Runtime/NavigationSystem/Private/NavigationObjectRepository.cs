namespace AssetTool
{
    [JsonAsset("NavigationObjectRepository")]
    public class UNavigationObjectRepository : UWorldSubsystem
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}