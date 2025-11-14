namespace AssetTool
{
    [JsonAsset("MovieSceneScriptingDoubleKey")]
    public class UMovieSceneScriptingDoubleKey : UMovieSceneScriptingKey
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MovieSceneScriptingDoubleChannel")]
    public class UMovieSceneScriptingDoubleChannel : UMovieSceneScriptingChannel
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}