namespace AssetTool
{
    [JsonAsset("MovieSceneEventSystem")]
    public class UMovieSceneEventSystem : UMovieSceneEntitySystem
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MovieScenePreSpawnEventSystem")]
    public class UMovieScenePreSpawnEventSystem : UMovieSceneEventSystem
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MovieScenePostSpawnEventSystem")]
    public class UMovieScenePostSpawnEventSystem : UMovieSceneEventSystem
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MovieScenePostEvalEventSystem")]
    public class UMovieScenePostEvalEventSystem : UMovieSceneEventSystem
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}