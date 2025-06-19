namespace AssetTool
{
    [JsonAsset("AvaSequenceActor")]
    public class AAvaSequenceActor : ALevelSequenceActor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}