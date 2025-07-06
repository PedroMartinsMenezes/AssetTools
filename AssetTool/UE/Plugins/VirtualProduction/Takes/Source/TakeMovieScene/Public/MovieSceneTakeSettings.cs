namespace AssetTool
{
    [JsonAsset("MovieSceneTakeSettings")]
    public class UMovieSceneTakeSettings : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}