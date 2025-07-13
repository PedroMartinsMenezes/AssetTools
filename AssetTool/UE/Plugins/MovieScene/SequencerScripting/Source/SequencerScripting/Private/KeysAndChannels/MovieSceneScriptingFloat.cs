namespace AssetTool
{
    [JsonAsset("MovieSceneScriptingFloatKey")]
    public class UMovieSceneScriptingFloatKey : UMovieSceneScriptingKey
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MovieSceneScriptingActualFloatKey")]
    public class UMovieSceneScriptingActualFloatKey : UMovieSceneScriptingFloatKey
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MovieSceneScriptingDoubleAsFloatKey")]
    public class UMovieSceneScriptingDoubleAsFloatKey : UMovieSceneScriptingFloatKey
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MovieSceneScriptingFloatChannel")]
    public class UMovieSceneScriptingFloatChannel : UMovieSceneScriptingChannel
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}