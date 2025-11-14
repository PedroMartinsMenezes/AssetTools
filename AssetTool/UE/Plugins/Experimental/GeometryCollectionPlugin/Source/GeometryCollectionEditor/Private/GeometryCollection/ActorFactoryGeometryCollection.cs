namespace AssetTool
{
    [JsonAsset("ActorFactoryGeometryCollection")]
    public class UActorFactoryGeometryCollection : UActorFactory
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}