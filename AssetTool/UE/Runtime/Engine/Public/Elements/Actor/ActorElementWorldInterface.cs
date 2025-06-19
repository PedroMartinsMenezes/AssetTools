namespace AssetTool
{
    [JsonAsset("ActorElementWorldInterface")]
    public class UActorElementWorldInterface : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}