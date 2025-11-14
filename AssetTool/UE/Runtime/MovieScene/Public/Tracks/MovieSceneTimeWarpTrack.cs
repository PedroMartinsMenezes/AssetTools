namespace AssetTool
{
    [JsonAsset("MovieSceneTimeWarpTrack")]
    public class UMovieSceneTimeWarpTrack : UMovieSceneTrack
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}