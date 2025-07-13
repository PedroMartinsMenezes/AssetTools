namespace AssetTool
{
    [JsonAsset("MoviePlayerSettings")]
    public class UMoviePlayerSettings : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}