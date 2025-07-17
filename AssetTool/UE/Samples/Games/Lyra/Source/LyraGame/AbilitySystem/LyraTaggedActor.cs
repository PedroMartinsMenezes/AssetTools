namespace AssetTool
{
    [JsonAsset("LyraTaggedActor")]
    public class ALyraTaggedActor : AActor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}