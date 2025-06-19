namespace AssetTool
{
    [JsonAsset("AvaSequencePlayer")]
    public class UAvaSequencePlayer : ULevelSequencePlayer
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}