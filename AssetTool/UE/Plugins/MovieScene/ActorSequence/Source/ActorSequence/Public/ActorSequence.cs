namespace AssetTool
{
    [JsonAsset("ActorSequence")]
    public class UActorSequence : UMovieSceneSequence
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}