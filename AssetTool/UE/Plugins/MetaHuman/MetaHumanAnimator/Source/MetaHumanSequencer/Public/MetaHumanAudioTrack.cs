namespace AssetTool
{
    [JsonAsset("MetaHumanAudioTrack")]
    public class UMetaHumanAudioTrack : UMovieSceneAudioTrack
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}