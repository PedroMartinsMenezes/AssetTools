namespace AssetTool
{
    [JsonAsset("LyraReplicationGraphSettings")]
    public class ULyraReplicationGraphSettings : UDeveloperSettingsBackedByCVars
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}