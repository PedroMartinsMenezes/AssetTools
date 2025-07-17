namespace AssetTool
{
    [JsonAsset("LyraDeveloperSettings")]
    public class ULyraDeveloperSettings : UDeveloperSettingsBackedByCVars
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}