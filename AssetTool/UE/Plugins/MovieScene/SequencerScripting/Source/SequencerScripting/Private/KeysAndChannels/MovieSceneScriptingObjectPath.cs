namespace AssetTool
{
    [JsonAsset("MovieSceneScriptingObjectPathKey")]
    public class UMovieSceneScriptingObjectPathKey : UMovieSceneScriptingKey
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MovieSceneScriptingObjectPathChannel")]
    public class UMovieSceneScriptingObjectPathChannel : UMovieSceneScriptingChannel
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}