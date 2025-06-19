namespace AssetTool
{
    [JsonAsset("ActorFactoryFlesh")]
    public class UActorFactoryFlesh : UActorFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}