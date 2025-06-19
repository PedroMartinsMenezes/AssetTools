namespace AssetTool
{
    [JsonAsset("MovieSceneCondition")]
    public class UMovieSceneCondition : UMovieSceneSignedObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}