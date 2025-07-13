namespace AssetTool
{
    [JsonAsset("SculptBrushProperties")]
    public class USculptBrushProperties : UInteractiveToolPropertySet
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("KelvinBrushProperties")]
    public class UKelvinBrushProperties : UInteractiveToolPropertySet
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("WorkPlaneProperties")]
    public class UWorkPlaneProperties : UInteractiveToolPropertySet
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("SculptMaxBrushProperties")]
    public class USculptMaxBrushProperties : UInteractiveToolPropertySet
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MeshSculptToolBase")]
    public class UMeshSculptToolBase : UMeshSurfacePointTool
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}