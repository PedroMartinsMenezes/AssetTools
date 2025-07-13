namespace AssetTool
{
    [JsonAsset("BaseVoxelTool")]
    public class UBaseVoxelTool : UBaseCreateFromSelectedTool
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}