namespace AssetTool
{
    [JsonAsset("ActorFactoryAnimationAsset")]
    public class UActorFactoryAnimationAsset : UActorFactorySkeletalMesh
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}