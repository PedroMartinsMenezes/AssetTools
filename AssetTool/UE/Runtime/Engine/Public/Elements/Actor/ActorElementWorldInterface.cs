namespace AssetTool
{
    [JsonAsset("ActorElementWorldInterface")]
    public class UActorElementWorldInterface : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}