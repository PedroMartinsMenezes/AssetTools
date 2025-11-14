namespace AssetTool
{
    [JsonAsset("MVVMDeveloperProjectSettings")]
    public class UMVVMDeveloperProjectSettings : UDeveloperSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}