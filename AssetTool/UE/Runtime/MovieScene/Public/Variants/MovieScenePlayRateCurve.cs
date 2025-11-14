namespace AssetTool
{
    [JsonAsset("MovieScenePlayRateCurve")]
    public class UMovieScenePlayRateCurve : UMovieSceneTimeWarpGetter
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}