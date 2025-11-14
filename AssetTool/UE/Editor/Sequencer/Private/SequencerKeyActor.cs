namespace AssetTool
{
    [JsonAsset("SequencerKeyActor")]
    public class ASequencerKeyActor : AActor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}