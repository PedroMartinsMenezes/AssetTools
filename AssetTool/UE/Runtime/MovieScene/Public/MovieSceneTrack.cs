namespace AssetTool
{
    [JsonAsset("MovieSceneTrack")]
    public class UMovieSceneTrack : UMovieSceneSignedObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}