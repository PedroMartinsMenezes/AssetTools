namespace AssetTool
{
    [JsonAsset("LevelSequenceProjectSettings")]
    public class ULevelSequenceProjectSettings : UDeveloperSettings
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}