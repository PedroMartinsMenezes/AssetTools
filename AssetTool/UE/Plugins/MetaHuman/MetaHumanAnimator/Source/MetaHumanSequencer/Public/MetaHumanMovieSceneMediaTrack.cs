namespace AssetTool
{
    [JsonAsset("MetaHumanMovieSceneMediaTrack")]
    public class UMetaHumanMovieSceneMediaTrack : UMovieSceneMediaTrack
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}