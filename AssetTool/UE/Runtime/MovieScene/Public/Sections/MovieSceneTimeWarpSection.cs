namespace AssetTool
{
    [JsonAsset("MovieSceneTimeWarpSection")]
    public class UMovieSceneTimeWarpSection : UMovieSceneSection
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}