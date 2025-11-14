namespace AssetTool
{
    [JsonAsset("MovieSceneTrackInstance")]
    public class UMovieSceneTrackInstance : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}