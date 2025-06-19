namespace AssetTool
{
    [JsonAsset("MovieSceneGenericBoundObjectInstantiator")]
    public class UMovieSceneGenericBoundObjectInstantiator : UMovieSceneEntityInstantiatorSystem
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}