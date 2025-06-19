namespace AssetTool
{
    [JsonAsset("MovieSceneAudioTrack")]
    public class UMovieSceneAudioTrack : UMovieSceneNameableTrack
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}