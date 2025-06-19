namespace AssetTool
{
    [JsonAsset("MovieSceneFloatTrack")]
    public class UMovieSceneFloatTrack : UMovieScenePropertyTrack
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}