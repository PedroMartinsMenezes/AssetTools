namespace AssetTool
{
    [JsonAsset("MovieSceneMetaData")]
    public class UMovieSceneMetaData : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}