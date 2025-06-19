namespace AssetTool
{
    [JsonAsset("MovieSceneTrack")]
    public class UMovieSceneTrack : UMovieSceneSignedObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}