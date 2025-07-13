namespace AssetTool
{
    [JsonAsset("MVVMDeveloperProjectSettings")]
    public class UMVVMDeveloperProjectSettings : UDeveloperSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}