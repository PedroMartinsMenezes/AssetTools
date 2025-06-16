namespace AssetTool
{
    [JsonAsset("ActorFactoryClass")]
    public class UActorFactoryClass : UActorFactory
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}