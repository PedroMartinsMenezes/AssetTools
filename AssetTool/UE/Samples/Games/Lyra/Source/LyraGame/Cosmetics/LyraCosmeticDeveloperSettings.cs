namespace AssetTool
{
    [JsonAsset("LyraCosmeticDeveloperSettings")]
    public class ULyraCosmeticDeveloperSettings : UDeveloperSettingsBackedByCVars
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}