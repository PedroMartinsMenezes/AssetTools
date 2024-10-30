namespace AssetTool
{
    [JsonAsset("ActorElementObjectInterface")]
    public class UActorElementObjectInterface : UObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}