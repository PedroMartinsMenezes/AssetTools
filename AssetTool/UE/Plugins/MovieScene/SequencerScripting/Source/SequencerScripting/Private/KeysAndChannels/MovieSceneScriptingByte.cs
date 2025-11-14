namespace AssetTool
{
    [JsonAsset("MovieSceneScriptingByteKey")]
    public class UMovieSceneScriptingByteKey : UMovieSceneScriptingKey
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MovieSceneScriptingByteChannel")]
    public class UMovieSceneScriptingByteChannel : UMovieSceneScriptingChannel
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}