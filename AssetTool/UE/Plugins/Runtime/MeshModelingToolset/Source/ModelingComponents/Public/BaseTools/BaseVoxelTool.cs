namespace AssetTool
{
    [JsonAsset("BaseVoxelTool")]
    public class UBaseVoxelTool : UBaseCreateFromSelectedTool
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}