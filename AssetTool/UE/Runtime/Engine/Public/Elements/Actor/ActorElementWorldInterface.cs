namespace AssetTool
{
    [JsonAsset("ActorElementWorldInterface")]
    public class UActorElementWorldInterface : UObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}