namespace AssetTool
{
    [JsonAsset("NavigationPath")]
    public class UNavigationPath : UObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}