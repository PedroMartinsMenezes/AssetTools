namespace AssetTool
{
    [JsonAsset("TakeRecorder")]
    public class UTakeRecorder : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}