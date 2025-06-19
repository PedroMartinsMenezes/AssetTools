namespace AssetTool
{
    [JsonAsset("MovieSceneFloatVectorPropertySystem")]
    public class UMovieSceneFloatVectorPropertySystem : UMovieScenePropertySystem
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MovieSceneDoubleVectorPropertySystem")]
    public class UMovieSceneDoubleVectorPropertySystem : UMovieScenePropertySystem
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}