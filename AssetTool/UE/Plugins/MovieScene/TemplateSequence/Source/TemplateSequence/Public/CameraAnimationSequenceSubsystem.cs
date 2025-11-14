namespace AssetTool
{
    [JsonAsset("CameraAnimationSpawnableSystem")]
    public class UCameraAnimationSpawnableSystem : UMovieSceneEntitySystem
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("CameraAnimationBoundObjectInstantiator")]
    public class UCameraAnimationBoundObjectInstantiator : UMovieSceneEntityInstantiatorSystem
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("CameraAnimationEntitySystemLinker")]
    public class UCameraAnimationEntitySystemLinker : UMovieSceneEntitySystemLinker
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("CameraAnimationSequenceSubsystem")]
    public class UCameraAnimationSequenceSubsystem : UWorldSubsystem
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}