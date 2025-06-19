namespace AssetTool
{
    [JsonAsset("AvaSequence")]
    public class UAvaSequence : ULevelSequence
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}