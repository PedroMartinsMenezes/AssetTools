namespace AssetTool
{
    [JsonAsset("DragAlignmentMechanic")]
    public class UDragAlignmentMechanic : UInteractionMechanic
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("DragAlignmentInteraction")]
    public class UDragAlignmentInteraction : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}