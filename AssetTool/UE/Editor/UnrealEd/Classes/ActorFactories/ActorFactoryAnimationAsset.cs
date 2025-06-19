namespace AssetTool
{
    [JsonAsset("ActorFactoryAnimationAsset")]
    public class UActorFactoryAnimationAsset : UActorFactorySkeletalMesh
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}