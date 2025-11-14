namespace AssetTool
{
    [JsonAsset("NavigationObjectRepository")]
    public class UNavigationObjectRepository : UWorldSubsystem
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}