namespace AssetTool
{
    [JsonAsset("TakeRecorderLevelSequenceSource")]
    public class UTakeRecorderLevelSequenceSource : UTakeRecorderSource
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}