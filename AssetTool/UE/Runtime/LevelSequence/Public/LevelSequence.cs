namespace AssetTool
{
    [JsonAsset("LevelSequence")]
    public class ULevelSequence : UMovieSceneSequence
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}