namespace AssetTool
{
    [JsonAsset("MovieGraphSchema")]
    public class UMovieGraphSchema : UEdGraphSchema
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}