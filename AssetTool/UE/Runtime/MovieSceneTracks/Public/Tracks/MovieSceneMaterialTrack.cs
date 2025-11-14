namespace AssetTool
{
    [JsonAsset("MovieSceneMaterialTrack")]
    public class UMovieSceneMaterialTrack : UMovieSceneNameableTrack
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MovieSceneComponentMaterialTrack")]
    public class UMovieSceneComponentMaterialTrack : UMovieSceneMaterialTrack
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}