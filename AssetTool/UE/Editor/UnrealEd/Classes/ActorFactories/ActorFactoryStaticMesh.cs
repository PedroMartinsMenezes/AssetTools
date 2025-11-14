namespace AssetTool
{
    [JsonAsset("ActorFactoryStaticMesh")]
    public class UActorFactoryStaticMesh : UActorFactory
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}