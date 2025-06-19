namespace AssetTool
{
    [JsonAsset("MovieSceneFolder")]
    public class UMovieSceneFolder : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}