namespace AssetTool
{
    [JsonAsset("DrawSplineToolProperties")]
    public class UDrawSplineToolProperties : UInteractiveToolPropertySet
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("DrawSplineTool")]
    public class UDrawSplineTool : UInteractiveTool
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("DrawSplineToolBuilder")]
    public class UDrawSplineToolBuilder : UInteractiveToolBuilder
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}