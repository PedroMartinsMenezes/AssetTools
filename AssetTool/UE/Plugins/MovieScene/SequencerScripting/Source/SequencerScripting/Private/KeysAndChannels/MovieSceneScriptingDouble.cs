namespace AssetTool
{
    [JsonAsset("MovieSceneScriptingDoubleKey")]
    public class UMovieSceneScriptingDoubleKey : UMovieSceneScriptingKey
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MovieSceneScriptingDoubleChannel")]
    public class UMovieSceneScriptingDoubleChannel : UMovieSceneScriptingChannel
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}