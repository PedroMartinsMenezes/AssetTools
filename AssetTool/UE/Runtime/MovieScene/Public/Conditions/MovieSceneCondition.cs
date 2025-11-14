namespace AssetTool
{
    [JsonAsset("MovieSceneCondition")]
    public class UMovieSceneCondition : UMovieSceneSignedObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}