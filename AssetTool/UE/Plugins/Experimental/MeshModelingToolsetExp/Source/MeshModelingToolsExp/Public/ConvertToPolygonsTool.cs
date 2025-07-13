namespace AssetTool
{
    [JsonAsset("ConvertToPolygonsToolBuilder")]
    public class UConvertToPolygonsToolBuilder : USingleTargetWithSelectionToolBuilder
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ConvertToPolygonsToolProperties")]
    public class UConvertToPolygonsToolProperties : UInteractiveToolPropertySet
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ConvertToPolygonsOperatorFactory")]
    public class UConvertToPolygonsOperatorFactory : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ConvertToPolygonsTool")]
    public class UConvertToPolygonsTool : USingleTargetWithSelectionTool
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}