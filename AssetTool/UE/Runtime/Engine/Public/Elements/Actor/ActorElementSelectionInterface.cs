namespace AssetTool
{
    [JsonAsset("ActorElementSelectionInterface")]
    public class UActorElementSelectionInterface : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}