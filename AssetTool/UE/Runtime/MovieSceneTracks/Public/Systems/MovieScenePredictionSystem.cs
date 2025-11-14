namespace AssetTool
{
    [JsonAsset("MovieSceneAsyncAction_SequencePrediction")]
    public class UMovieSceneAsyncAction_SequencePrediction : UBlueprintAsyncActionBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MovieScenePredictionSystem")]
    public class UMovieScenePredictionSystem : UMovieSceneEntitySystem
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}