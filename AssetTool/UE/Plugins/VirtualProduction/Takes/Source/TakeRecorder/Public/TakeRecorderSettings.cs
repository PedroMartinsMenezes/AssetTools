namespace AssetTool
{
    [JsonAsset("TakeRecorderUserSettings")]
    public class UTakeRecorderUserSettings : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("TakeRecorderProjectSettings")]
    public class UTakeRecorderProjectSettings : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}