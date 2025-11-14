namespace AssetTool
{
    [JsonAsset("MovieSceneScriptingIntegerKey")]
    public class UMovieSceneScriptingIntegerKey : UMovieSceneScriptingKey
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MovieSceneScriptingIntegerChannel")]
    public class UMovieSceneScriptingIntegerChannel : UMovieSceneScriptingChannel
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}