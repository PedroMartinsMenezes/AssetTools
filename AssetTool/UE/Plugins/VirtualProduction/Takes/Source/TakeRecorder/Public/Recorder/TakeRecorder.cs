namespace AssetTool
{
    [JsonAsset("TakeRecorder")]
    public class UTakeRecorder : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}