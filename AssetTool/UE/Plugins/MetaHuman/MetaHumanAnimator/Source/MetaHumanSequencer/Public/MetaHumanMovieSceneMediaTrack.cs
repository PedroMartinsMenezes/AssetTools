namespace AssetTool
{
    [JsonAsset("MetaHumanMovieSceneMediaTrack")]
    public class UMetaHumanMovieSceneMediaTrack : UMovieSceneMediaTrack
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}