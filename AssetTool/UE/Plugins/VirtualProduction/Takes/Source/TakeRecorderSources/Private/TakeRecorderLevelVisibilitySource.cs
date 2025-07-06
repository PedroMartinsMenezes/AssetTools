namespace AssetTool
{
    [JsonAsset("TakeRecorderLevelVisibilitySourceSettings")]
    public class UTakeRecorderLevelVisibilitySourceSettings : UTakeRecorderSource
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("TakeRecorderLevelVisibilitySource")]
    public class UTakeRecorderLevelVisibilitySource : UTakeRecorderLevelVisibilitySourceSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}