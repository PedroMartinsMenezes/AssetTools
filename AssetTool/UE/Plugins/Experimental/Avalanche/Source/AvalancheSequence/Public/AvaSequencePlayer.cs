namespace AssetTool
{
    [JsonAsset("AvaSequencePlayer")]
    public class UAvaSequencePlayer : ULevelSequencePlayer
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}