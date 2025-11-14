namespace AssetTool
{
    [JsonAsset("MoverDeveloperSettings")]
    public class UMoverDeveloperSettings : UDeveloperSettingsBackedByCVars
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}