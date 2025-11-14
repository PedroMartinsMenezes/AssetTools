namespace AssetTool
{
    [JsonAsset("VolumeToMeshToolBuilder")]
    public class UVolumeToMeshToolBuilder : UInteractiveToolBuilder
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("VolumeToMeshToolProperties")]
    public class UVolumeToMeshToolProperties : UInteractiveToolPropertySet
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("VolumeToMeshTool")]
    public class UVolumeToMeshTool : UInteractiveTool
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}