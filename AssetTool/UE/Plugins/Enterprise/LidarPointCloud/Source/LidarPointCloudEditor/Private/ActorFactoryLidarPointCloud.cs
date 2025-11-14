namespace AssetTool
{
    [JsonAsset("ActorFactoryLidarPointCloud")]
    public class UActorFactoryLidarPointCloud : UActorFactory
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}