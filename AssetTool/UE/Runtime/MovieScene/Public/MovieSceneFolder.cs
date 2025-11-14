namespace AssetTool
{
    [JsonAsset("MovieSceneFolder")]
    public class UMovieSceneFolder : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}