namespace AssetTool
{
    [JsonAsset("SequencerKeyActor")]
    public class ASequencerKeyActor : AActor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}