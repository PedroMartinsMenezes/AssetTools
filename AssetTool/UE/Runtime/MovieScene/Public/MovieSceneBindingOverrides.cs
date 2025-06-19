namespace AssetTool
{
    [JsonAsset("MovieSceneBindingOverrides")]
    public class UMovieSceneBindingOverrides : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}