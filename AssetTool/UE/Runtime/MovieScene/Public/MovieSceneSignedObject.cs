namespace AssetTool
{
    [JsonAsset("MovieSceneSignedObject")]
    public class UMovieSceneSignedObject : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}