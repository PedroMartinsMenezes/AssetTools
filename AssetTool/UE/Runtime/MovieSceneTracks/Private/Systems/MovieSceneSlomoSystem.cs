namespace AssetTool
{
    [JsonAsset("MovieSceneSlomoSystem")]
    public class UMovieSceneSlomoSystem : UMovieSceneEntitySystem
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}