namespace AssetTool
{
    [JsonAsset("MovieSceneAudioSection")]
    public class UMovieSceneAudioSection : UMovieSceneSection
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}