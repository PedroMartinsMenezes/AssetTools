namespace AssetTool
{
    [JsonAsset("VirtualHeightfieldMeshComponent")]
    public class UVirtualHeightfieldMeshComponent : UPrimitiveComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}