namespace AssetTool
{
    [JsonAsset("AvaSequenceDirector")]
    public class UAvaSequenceDirector : ULevelSequenceDirector
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}