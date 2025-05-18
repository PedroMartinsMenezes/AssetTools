namespace AssetTool
{
    [JsonAsset("AvaSequence")]
    public class UAvaSequence : ULevelSequence
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}