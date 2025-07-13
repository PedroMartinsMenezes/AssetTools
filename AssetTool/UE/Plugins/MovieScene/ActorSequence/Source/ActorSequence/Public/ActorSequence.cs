namespace AssetTool
{
    [JsonAsset("ActorSequence")]
    public class UActorSequence : UMovieSceneSequence
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}