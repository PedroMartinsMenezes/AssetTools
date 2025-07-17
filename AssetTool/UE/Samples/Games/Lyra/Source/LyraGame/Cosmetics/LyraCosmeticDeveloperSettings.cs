namespace AssetTool
{
    [JsonAsset("LyraCosmeticDeveloperSettings")]
    public class ULyraCosmeticDeveloperSettings : UDeveloperSettingsBackedByCVars
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}