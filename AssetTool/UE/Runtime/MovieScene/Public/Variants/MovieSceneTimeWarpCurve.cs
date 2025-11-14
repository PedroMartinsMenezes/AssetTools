namespace AssetTool
{
    [JsonAsset("MovieSceneTimeWarpCurve")]
    public class UMovieSceneTimeWarpCurve : UMovieSceneTimeWarpGetter
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}