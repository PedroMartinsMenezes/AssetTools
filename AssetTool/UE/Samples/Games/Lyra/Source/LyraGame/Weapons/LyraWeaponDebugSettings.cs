namespace AssetTool
{
    [JsonAsset("LyraWeaponDebugSettings")]
    public class ULyraWeaponDebugSettings : UDeveloperSettingsBackedByCVars
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}