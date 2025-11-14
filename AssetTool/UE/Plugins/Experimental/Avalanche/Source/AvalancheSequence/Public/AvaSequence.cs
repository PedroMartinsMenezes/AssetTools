namespace AssetTool
{
    [JsonAsset("AvaSequence")]
    public class UAvaSequence : ULevelSequence
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}