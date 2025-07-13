namespace AssetTool
{
    [JsonAsset("ActorSequencePlayer")]
    public class UActorSequencePlayer : UMovieSceneSequencePlayer
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}