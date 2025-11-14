namespace AssetTool
{
    [JsonAsset("LevelSequenceProjectSettings")]
    public class ULevelSequenceProjectSettings : UDeveloperSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}