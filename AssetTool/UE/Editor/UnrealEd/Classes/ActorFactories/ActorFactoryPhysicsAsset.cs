namespace AssetTool
{
    [JsonAsset("ActorFactoryPhysicsAsset")]
    public class UActorFactoryPhysicsAsset : UActorFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}