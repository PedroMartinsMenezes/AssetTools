namespace AssetTool
{
    [JsonAsset("TakeRecorderWorldSourceSettings")]
    public class UTakeRecorderWorldSourceSettings : UTakeRecorderSource
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("TakeRecorderWorldSource")]
    public class UTakeRecorderWorldSource : UTakeRecorderWorldSourceSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}