namespace AssetTool
{
    [JsonAsset("ActorFactoryFlesh")]
    public class UActorFactoryFlesh : UActorFactory
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}