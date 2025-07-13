namespace AssetTool
{
    [JsonAsset("MovieSceneScriptingBoolKey")]
    public class UMovieSceneScriptingBoolKey : UMovieSceneScriptingKey
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MovieSceneScriptingBoolChannel")]
    public class UMovieSceneScriptingBoolChannel : UMovieSceneScriptingChannel
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}