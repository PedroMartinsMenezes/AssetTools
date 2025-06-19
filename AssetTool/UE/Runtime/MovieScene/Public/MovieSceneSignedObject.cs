namespace AssetTool
{
    [JsonAsset("MovieSceneSignedObject")]
    public class UMovieSceneSignedObject : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}