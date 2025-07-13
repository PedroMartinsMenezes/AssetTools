namespace AssetTool
{
    [JsonAsset("MovieSceneScriptingEventKey")]
    public class UMovieSceneScriptingEventKey : UMovieSceneScriptingKey
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MovieSceneScriptingEventChannel")]
    public class UMovieSceneScriptingEventChannel : UMovieSceneScriptingChannel
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}