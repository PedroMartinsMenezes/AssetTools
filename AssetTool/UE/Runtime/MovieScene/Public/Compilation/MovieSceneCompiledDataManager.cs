namespace AssetTool
{
    [JsonAsset("MovieSceneCompiledData")]
    public class UMovieSceneCompiledData : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MovieSceneCompiledDataManager")]
    public class UMovieSceneCompiledDataManager : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}