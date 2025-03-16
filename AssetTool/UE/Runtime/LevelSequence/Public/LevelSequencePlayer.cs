namespace AssetTool
{
    [JsonAsset("LevelSequencePlayer")]
    public class ULevelSequencePlayer : UMovieSceneSequencePlayer
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}