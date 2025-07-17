namespace AssetTool
{
    [JsonAsset("LyraReplicationGraphSettings")]
    public class ULyraReplicationGraphSettings : UDeveloperSettingsBackedByCVars
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}