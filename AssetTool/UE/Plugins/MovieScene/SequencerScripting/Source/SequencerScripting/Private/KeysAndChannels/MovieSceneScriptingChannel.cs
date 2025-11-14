namespace AssetTool
{
    [JsonAsset("MovieSceneScriptingKey")]
    public class UMovieSceneScriptingKey : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MovieSceneScriptingChannel")]
    public class UMovieSceneScriptingChannel : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}