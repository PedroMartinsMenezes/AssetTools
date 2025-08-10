namespace AssetTool
{
    [JsonAsset("MetaHumanAudioTrack")]
    public class UMetaHumanAudioTrack : UMovieSceneAudioTrack
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}