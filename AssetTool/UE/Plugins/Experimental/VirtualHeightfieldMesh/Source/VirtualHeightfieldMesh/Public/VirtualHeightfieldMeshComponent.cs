namespace AssetTool
{
    [JsonAsset("VirtualHeightfieldMeshComponent")]
    public class UVirtualHeightfieldMeshComponent : UPrimitiveComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}