namespace AssetTool
{
    [JsonAsset("LyraTaggedActor")]
    public class ALyraTaggedActor : AActor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}