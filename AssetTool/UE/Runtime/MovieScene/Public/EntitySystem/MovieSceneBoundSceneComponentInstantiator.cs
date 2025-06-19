namespace AssetTool
{
    [JsonAsset("MovieSceneBoundSceneComponentInstantiator")]
    public class UMovieSceneBoundSceneComponentInstantiator : UMovieSceneEntityInstantiatorSystem
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}