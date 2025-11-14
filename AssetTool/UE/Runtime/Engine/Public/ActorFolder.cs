namespace AssetTool
{
    [JsonAsset("ActorFolder")]
    public class UActorFolder : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}