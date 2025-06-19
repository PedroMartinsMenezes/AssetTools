namespace AssetTool
{
    [JsonAsset("ActorFactoryStaticMesh")]
    public class UActorFactoryStaticMesh : UActorFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}