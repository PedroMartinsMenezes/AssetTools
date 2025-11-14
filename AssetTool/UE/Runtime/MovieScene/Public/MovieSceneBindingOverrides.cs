namespace AssetTool
{
    [JsonAsset("MovieSceneBindingOverrides")]
    public class UMovieSceneBindingOverrides : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}