namespace AssetTool
{
    [JsonAsset("LevelCapture")]
    public class ULevelCapture : UMovieSceneCapture
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}