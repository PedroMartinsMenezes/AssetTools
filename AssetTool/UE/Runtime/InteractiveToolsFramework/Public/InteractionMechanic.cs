namespace AssetTool
{
    [JsonAsset("InteractionMechanic")]
    public class UInteractionMechanic : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}