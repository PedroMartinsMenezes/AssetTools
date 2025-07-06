namespace AssetTool
{
    [JsonAsset("TakeRecorderPlayerSource")]
    public class UTakeRecorderPlayerSource : UTakeRecorderSource
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}