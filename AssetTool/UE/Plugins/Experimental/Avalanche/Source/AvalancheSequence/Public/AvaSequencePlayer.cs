namespace AssetTool
{
    [JsonAsset("AvaSequencePlayer")]
    public class UAvaSequencePlayer : ULevelSequencePlayer
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}