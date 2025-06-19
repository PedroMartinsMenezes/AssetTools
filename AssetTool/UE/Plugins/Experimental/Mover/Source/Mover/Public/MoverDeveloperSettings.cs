namespace AssetTool
{
    [JsonAsset("MoverDeveloperSettings")]
    public class UMoverDeveloperSettings : UDeveloperSettingsBackedByCVars
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}