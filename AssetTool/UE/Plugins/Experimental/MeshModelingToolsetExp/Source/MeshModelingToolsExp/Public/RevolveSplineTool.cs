namespace AssetTool
{
    [JsonAsset("RevolveSplineToolProperties")]
    public class URevolveSplineToolProperties : URevolveProperties
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("RevolveSplineToolActionPropertySet")]
    public class URevolveSplineToolActionPropertySet : UInteractiveToolPropertySet
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("RevolveSplineTool")]
    public class URevolveSplineTool : UBaseMeshFromSplinesTool
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("RevolveSplineToolBuilder")]
    public class URevolveSplineToolBuilder : UBaseMeshFromSplinesToolBuilder
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}