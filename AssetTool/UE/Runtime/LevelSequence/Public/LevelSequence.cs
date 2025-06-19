namespace AssetTool
{
    [JsonAsset("LevelSequence")]
    public class ULevelSequence : UMovieSceneSequence
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}