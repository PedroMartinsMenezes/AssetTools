namespace AssetTool
{
    [JsonAsset("LevelSequenceProjectSettings")]
    public class ULevelSequenceProjectSettings : UDeveloperSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}