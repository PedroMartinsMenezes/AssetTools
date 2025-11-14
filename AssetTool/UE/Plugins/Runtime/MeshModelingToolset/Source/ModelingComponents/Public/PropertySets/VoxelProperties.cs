namespace AssetTool
{
    [JsonAsset("VoxelProperties")]
    public class UVoxelProperties : UInteractiveToolPropertySet
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}