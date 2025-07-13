namespace AssetTool
{
    [JsonAsset("VolumeToMeshToolBuilder")]
    public class UVolumeToMeshToolBuilder : UInteractiveToolBuilder
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("VolumeToMeshToolProperties")]
    public class UVolumeToMeshToolProperties : UInteractiveToolPropertySet
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("VolumeToMeshTool")]
    public class UVolumeToMeshTool : UInteractiveTool
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}