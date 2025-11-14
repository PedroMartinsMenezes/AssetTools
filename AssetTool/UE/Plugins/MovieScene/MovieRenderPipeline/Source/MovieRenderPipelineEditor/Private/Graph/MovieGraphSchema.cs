namespace AssetTool
{
    [JsonAsset("MovieGraphSchema")]
    public class UMovieGraphSchema : UEdGraphSchema
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}