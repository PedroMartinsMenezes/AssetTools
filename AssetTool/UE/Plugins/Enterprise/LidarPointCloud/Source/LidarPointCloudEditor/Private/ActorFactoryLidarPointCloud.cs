namespace AssetTool
{
    [JsonAsset("ActorFactoryLidarPointCloud")]
    public class UActorFactoryLidarPointCloud : UActorFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}