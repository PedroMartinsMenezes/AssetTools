namespace AssetTool
{
    [JsonAsset("CommonLoadingScreenSettings")]
    public class UCommonLoadingScreenSettings : UDeveloperSettingsBackedByCVars
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}