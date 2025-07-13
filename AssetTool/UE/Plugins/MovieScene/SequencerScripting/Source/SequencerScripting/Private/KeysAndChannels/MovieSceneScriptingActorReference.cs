namespace AssetTool
{
    [JsonAsset("MovieSceneScriptingActorReferenceKey")]
    public class UMovieSceneScriptingActorReferenceKey : UMovieSceneScriptingKey
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MovieSceneScriptingActorReferenceChannel")]
    public class UMovieSceneScriptingActorReferenceChannel : UMovieSceneScriptingChannel
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}