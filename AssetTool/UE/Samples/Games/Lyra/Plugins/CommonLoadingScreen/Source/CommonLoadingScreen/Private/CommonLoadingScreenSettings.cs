namespace AssetTool
{
    [JsonAsset("CommonLoadingScreenSettings")]
    public class UCommonLoadingScreenSettings : UDeveloperSettingsBackedByCVars
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}