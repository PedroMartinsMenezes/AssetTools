namespace AssetTool
{
    [JsonAsset("SculptBrushProperties")]
    public class USculptBrushProperties : UInteractiveToolPropertySet
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("KelvinBrushProperties")]
    public class UKelvinBrushProperties : UInteractiveToolPropertySet
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("WorkPlaneProperties")]
    public class UWorkPlaneProperties : UInteractiveToolPropertySet
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("SculptMaxBrushProperties")]
    public class USculptMaxBrushProperties : UInteractiveToolPropertySet
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MeshSculptToolBase")]
    public class UMeshSculptToolBase : UMeshSurfacePointTool
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}