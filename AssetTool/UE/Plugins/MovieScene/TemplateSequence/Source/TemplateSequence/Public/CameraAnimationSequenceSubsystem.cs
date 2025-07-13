namespace AssetTool
{
    [JsonAsset("CameraAnimationSpawnableSystem")]
    public class UCameraAnimationSpawnableSystem : UMovieSceneEntitySystem
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("CameraAnimationBoundObjectInstantiator")]
    public class UCameraAnimationBoundObjectInstantiator : UMovieSceneEntityInstantiatorSystem
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("CameraAnimationEntitySystemLinker")]
    public class UCameraAnimationEntitySystemLinker : UMovieSceneEntitySystemLinker
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("CameraAnimationSequenceSubsystem")]
    public class UCameraAnimationSequenceSubsystem : UWorldSubsystem
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}