namespace AssetTool
{
    [JsonAsset("ActorFactoryAnimationAsset")]
    public class UActorFactoryAnimationAsset : UActorFactorySkeletalMesh
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}