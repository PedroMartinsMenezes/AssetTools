namespace AssetTool
{
    [JsonAsset("LyraDeveloperSettings")]
    public class ULyraDeveloperSettings : UDeveloperSettingsBackedByCVars
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}