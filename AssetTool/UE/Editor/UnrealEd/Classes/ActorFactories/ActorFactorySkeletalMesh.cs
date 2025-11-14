namespace AssetTool
{
    [JsonAsset("ActorFactorySkeletalMesh")]
    public class UActorFactorySkeletalMesh : UActorFactory
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}