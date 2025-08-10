namespace AssetTool
{
    [JsonAsset("MetaHumanMovieSceneMediaSection")]
    public class UMetaHumanMovieSceneMediaSection : UMovieSceneMediaSection
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}