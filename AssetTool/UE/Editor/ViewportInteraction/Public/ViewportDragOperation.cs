namespace AssetTool
{
    [JsonAsset("ViewportDragOperation")]
    public class UViewportDragOperation : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ViewportDragOperationComponent")]
    public class UViewportDragOperationComponent : UActorComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}