namespace AssetTool
{
    [JsonAsset("NavigationPath")]
    public class UNavigationPath : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}