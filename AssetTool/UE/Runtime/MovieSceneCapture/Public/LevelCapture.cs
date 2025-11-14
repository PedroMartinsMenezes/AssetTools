namespace AssetTool
{
    [JsonAsset("LevelCapture")]
    public class ULevelCapture : UMovieSceneCapture
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}