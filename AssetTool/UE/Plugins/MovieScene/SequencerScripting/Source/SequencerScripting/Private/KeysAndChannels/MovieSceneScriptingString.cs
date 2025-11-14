namespace AssetTool
{
    [JsonAsset("MovieSceneScriptingStringKey")]
    public class UMovieSceneScriptingStringKey : UMovieSceneScriptingKey
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MovieSceneScriptingStringChannel")]
    public class UMovieSceneScriptingStringChannel : UMovieSceneScriptingChannel
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}