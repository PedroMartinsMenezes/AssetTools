namespace AssetTool
{
    [JsonAsset("MovieSceneTimeWarpCurve")]
    public class UMovieSceneTimeWarpCurve : UMovieSceneTimeWarpGetter
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}