namespace AssetTool
{
    [JsonAsset("MovieSceneTimeWarpSection")]
    public class UMovieSceneTimeWarpSection : UMovieSceneSection
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}