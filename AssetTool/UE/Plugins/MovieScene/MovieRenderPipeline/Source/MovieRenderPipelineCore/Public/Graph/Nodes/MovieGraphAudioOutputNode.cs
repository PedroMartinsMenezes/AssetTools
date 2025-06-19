namespace AssetTool
{
    [JsonAsset("MovieGraphAudioOutputNode")]
    public class UMovieGraphAudioOutputNode : UMovieGraphFileOutputNode
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}