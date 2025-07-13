namespace AssetTool
{
    [JsonAsset("MovieSceneScriptingByteKey")]
    public class UMovieSceneScriptingByteKey : UMovieSceneScriptingKey
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MovieSceneScriptingByteChannel")]
    public class UMovieSceneScriptingByteChannel : UMovieSceneScriptingChannel
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}