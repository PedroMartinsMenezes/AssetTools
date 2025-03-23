namespace AssetTool
{
    [JsonAsset("MovieSceneFloatVectorPropertySystem")]
    public class UMovieSceneFloatVectorPropertySystem : UMovieScenePropertySystem
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MovieSceneDoubleVectorPropertySystem")]
    public class UMovieSceneDoubleVectorPropertySystem : UMovieScenePropertySystem
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}