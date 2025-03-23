namespace AssetTool
{
    [JsonAsset("MovieSceneHierarchicalEasingInstantiatorSystem")]
    public class UMovieSceneHierarchicalEasingInstantiatorSystem : UMovieSceneEntityInstantiatorSystem
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MovieSceneHierarchicalEasingFinalizationSystem")]
    public class UMovieSceneHierarchicalEasingFinalizationSystem : UMovieSceneEntityInstantiatorSystem
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("WeightAndEasingEvaluatorSystem")]
    public class UWeightAndEasingEvaluatorSystem : UMovieSceneEntitySystem
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}