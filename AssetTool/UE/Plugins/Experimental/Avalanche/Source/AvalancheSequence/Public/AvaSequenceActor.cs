namespace AssetTool
{
    [JsonAsset("AvaSequenceActor")]
    public class AAvaSequenceActor : ALevelSequenceActor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}