namespace AssetTool
{
    [JsonAsset("ActorElementDetailsInterface")]
    public class UActorElementDetailsInterface : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}