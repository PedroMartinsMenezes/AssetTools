namespace AssetTool
{
    [JsonAsset("DragAlignmentMechanic")]
    public class UDragAlignmentMechanic : UInteractionMechanic
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("DragAlignmentInteraction")]
    public class UDragAlignmentInteraction : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}