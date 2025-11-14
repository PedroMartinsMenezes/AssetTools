namespace AssetTool
{
    [JsonAsset("MovieSceneComponentMobilitySystem")]
    public class UMovieSceneComponentMobilitySystem : UMovieSceneEntityInstantiatorSystem
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}