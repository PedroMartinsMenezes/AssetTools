namespace AssetTool
{
    [JsonAsset("AvaSequenceDirector")]
    public class UAvaSequenceDirector : ULevelSequenceDirector
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}