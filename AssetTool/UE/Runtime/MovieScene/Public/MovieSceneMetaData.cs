namespace AssetTool
{
    [JsonAsset("MovieSceneMetaData")]
    public class UMovieSceneMetaData : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}