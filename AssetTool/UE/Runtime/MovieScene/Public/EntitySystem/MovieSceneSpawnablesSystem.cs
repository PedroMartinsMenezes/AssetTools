namespace AssetTool
{
    [JsonAsset("MovieSceneSpawnablesSystem")]
    public class UMovieSceneSpawnablesSystem : UMovieSceneEntitySystem
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}