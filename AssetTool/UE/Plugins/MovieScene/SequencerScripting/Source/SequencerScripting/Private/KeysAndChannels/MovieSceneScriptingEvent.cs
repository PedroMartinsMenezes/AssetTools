namespace AssetTool
{
    [JsonAsset("MovieSceneScriptingEventKey")]
    public class UMovieSceneScriptingEventKey : UMovieSceneScriptingKey
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MovieSceneScriptingEventChannel")]
    public class UMovieSceneScriptingEventChannel : UMovieSceneScriptingChannel
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}