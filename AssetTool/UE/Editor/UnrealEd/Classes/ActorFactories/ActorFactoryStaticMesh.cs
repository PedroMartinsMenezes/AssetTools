namespace AssetTool
{
    [JsonAsset("ActorFactoryStaticMesh")]
    public class UActorFactoryStaticMesh : UActorFactory
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}