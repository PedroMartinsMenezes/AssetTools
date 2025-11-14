namespace AssetTool
{
    [JsonAsset("MovieGraphVideoOutputNode")]
    public class UMovieGraphVideoOutputNode : UMovieGraphFileOutputNode
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}