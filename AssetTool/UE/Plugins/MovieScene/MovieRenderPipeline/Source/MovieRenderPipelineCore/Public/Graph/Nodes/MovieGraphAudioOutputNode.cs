namespace AssetTool
{
    [JsonAsset("MovieGraphAudioOutputNode")]
    public class UMovieGraphAudioOutputNode : UMovieGraphFileOutputNode
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}