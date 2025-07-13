namespace AssetTool
{
    [JsonAsset("MovieSceneScriptingStringKey")]
    public class UMovieSceneScriptingStringKey : UMovieSceneScriptingKey
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MovieSceneScriptingStringChannel")]
    public class UMovieSceneScriptingStringChannel : UMovieSceneScriptingChannel
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}