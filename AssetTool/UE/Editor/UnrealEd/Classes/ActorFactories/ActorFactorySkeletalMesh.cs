namespace AssetTool
{
    [JsonAsset("ActorFactorySkeletalMesh")]
    public class UActorFactorySkeletalMesh : UActorFactory
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}