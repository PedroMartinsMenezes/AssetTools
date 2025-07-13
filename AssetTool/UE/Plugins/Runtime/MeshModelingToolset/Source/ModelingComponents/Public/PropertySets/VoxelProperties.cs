namespace AssetTool
{
    [JsonAsset("VoxelProperties")]
    public class UVoxelProperties : UInteractiveToolPropertySet
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}