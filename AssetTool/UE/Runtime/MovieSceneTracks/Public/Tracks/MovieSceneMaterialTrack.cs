namespace AssetTool
{
    [JsonAsset("MovieSceneMaterialTrack")]
    public class UMovieSceneMaterialTrack : UMovieSceneNameableTrack
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MovieSceneComponentMaterialTrack")]
    public class UMovieSceneComponentMaterialTrack : UMovieSceneMaterialTrack
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}