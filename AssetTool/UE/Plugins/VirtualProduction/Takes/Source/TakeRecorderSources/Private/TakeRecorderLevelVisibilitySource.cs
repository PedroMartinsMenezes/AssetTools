namespace AssetTool
{
    [JsonAsset("TakeRecorderLevelVisibilitySourceSettings")]
    public class UTakeRecorderLevelVisibilitySourceSettings : UTakeRecorderSource
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("TakeRecorderLevelVisibilitySource")]
    public class UTakeRecorderLevelVisibilitySource : UTakeRecorderLevelVisibilitySourceSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}