namespace AssetTool
{
    [JsonAsset("MovieSceneComponentMobilitySystem")]
    public class UMovieSceneComponentMobilitySystem : UMovieSceneEntityInstantiatorSystem
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}