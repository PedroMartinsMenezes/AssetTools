namespace AssetTool
{
    [JsonAsset("MovieScenePartialEvaluationTestObject")]
    public class UMovieScenePartialEvaluationTestObject : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}