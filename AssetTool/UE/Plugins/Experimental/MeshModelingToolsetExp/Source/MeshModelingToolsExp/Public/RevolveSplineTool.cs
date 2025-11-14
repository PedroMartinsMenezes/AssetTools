namespace AssetTool
{
    [JsonAsset("RevolveSplineToolProperties")]
    public class URevolveSplineToolProperties : URevolveProperties
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("RevolveSplineToolActionPropertySet")]
    public class URevolveSplineToolActionPropertySet : UInteractiveToolPropertySet
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("RevolveSplineTool")]
    public class URevolveSplineTool : UBaseMeshFromSplinesTool
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("RevolveSplineToolBuilder")]
    public class URevolveSplineToolBuilder : UBaseMeshFromSplinesToolBuilder
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}