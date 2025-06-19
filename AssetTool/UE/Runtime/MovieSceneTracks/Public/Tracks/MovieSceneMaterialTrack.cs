namespace AssetTool
{
    [JsonAsset("MovieSceneMaterialTrack")]
    public class UMovieSceneMaterialTrack : UMovieSceneNameableTrack
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MovieSceneComponentMaterialTrack")]
    public class UMovieSceneComponentMaterialTrack : UMovieSceneMaterialTrack
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}