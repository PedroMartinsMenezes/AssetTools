namespace AssetTool
{
    [JsonAsset("LevelSequencePlayer")]
    public class ULevelSequencePlayer : UMovieSceneSequencePlayer
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}