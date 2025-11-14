namespace AssetTool
{
    [JsonAsset("ActorSequencePlayer")]
    public class UActorSequencePlayer : UMovieSceneSequencePlayer
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}