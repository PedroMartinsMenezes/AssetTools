namespace AssetTool
{
    [JsonAsset("MovieSceneObjectPropertyTrack")]
    public class UMovieSceneObjectPropertyTrack : UMovieScenePropertyTrack
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}