namespace AssetTool
{
    [JsonAsset("ActorFactorySkeletalMesh")]
    public class UActorFactorySkeletalMesh : UActorFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}