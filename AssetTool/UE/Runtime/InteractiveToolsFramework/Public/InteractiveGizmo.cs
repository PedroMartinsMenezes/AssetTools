namespace AssetTool
{
    [JsonAsset("InteractiveGizmo")]
    public class UInteractiveGizmo : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}