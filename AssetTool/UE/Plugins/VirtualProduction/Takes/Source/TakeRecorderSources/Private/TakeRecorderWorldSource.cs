namespace AssetTool
{
    [JsonAsset("TakeRecorderWorldSourceSettings")]
    public class UTakeRecorderWorldSourceSettings : UTakeRecorderSource
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("TakeRecorderWorldSource")]
    public class UTakeRecorderWorldSource : UTakeRecorderWorldSourceSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}