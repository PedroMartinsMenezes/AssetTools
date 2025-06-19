namespace AssetTool
{
    [JsonAsset("MovieGraphSchema")]
    public class UMovieGraphSchema : UEdGraphSchema
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}