namespace AssetTool
{
    [JsonAsset("MovieSceneTakeSettings")]
    public class UMovieSceneTakeSettings : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}