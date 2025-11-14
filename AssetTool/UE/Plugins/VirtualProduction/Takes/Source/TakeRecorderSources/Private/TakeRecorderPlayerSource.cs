namespace AssetTool
{
    [JsonAsset("TakeRecorderPlayerSource")]
    public class UTakeRecorderPlayerSource : UTakeRecorderSource
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}