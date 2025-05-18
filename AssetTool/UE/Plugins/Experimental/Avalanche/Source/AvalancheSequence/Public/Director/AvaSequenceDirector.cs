namespace AssetTool
{
    [JsonAsset("AvaSequenceDirector")]
    public class UAvaSequenceDirector : ULevelSequenceDirector
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}