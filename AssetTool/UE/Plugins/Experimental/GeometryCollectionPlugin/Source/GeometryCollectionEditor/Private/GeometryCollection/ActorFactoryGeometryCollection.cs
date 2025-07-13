namespace AssetTool
{
    [JsonAsset("ActorFactoryGeometryCollection")]
    public class UActorFactoryGeometryCollection : UActorFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}