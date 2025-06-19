namespace AssetTool
{
    [JsonAsset("LevelSequencePlayer")]
    public class ULevelSequencePlayer : UMovieSceneSequencePlayer
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}