namespace AssetTool
{
    [JsonAsset("MovieGraphAudioOutputNode")]
    public class UMovieGraphAudioOutputNode : UMovieGraphFileOutputNode
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}