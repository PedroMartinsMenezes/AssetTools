namespace AssetTool
{
    [JsonAsset("MovieSceneTimeWarpGetter")]
    public class UMovieSceneTimeWarpGetter : UMovieSceneNumericVariantGetter
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}