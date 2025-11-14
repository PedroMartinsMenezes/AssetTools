namespace AssetTool
{
    [JsonAsset("InteractiveToolActivity")]
    public class UInteractiveToolActivity : UInteractionMechanic
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}