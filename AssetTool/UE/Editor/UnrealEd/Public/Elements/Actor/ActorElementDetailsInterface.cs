namespace AssetTool
{
    [JsonAsset("ActorElementDetailsInterface")]
    public class UActorElementDetailsInterface : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}