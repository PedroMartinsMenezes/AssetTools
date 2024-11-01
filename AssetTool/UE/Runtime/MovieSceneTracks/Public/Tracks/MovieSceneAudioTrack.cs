namespace AssetTool
{
    [JsonAsset("MovieSceneAudioTrack")]
    public class UMovieSceneAudioTrack : UMovieSceneNameableTrack
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}