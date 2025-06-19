namespace AssetTool
{
    [JsonAsset("ActorElementObjectInterface")]
    public class UActorElementObjectInterface : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}