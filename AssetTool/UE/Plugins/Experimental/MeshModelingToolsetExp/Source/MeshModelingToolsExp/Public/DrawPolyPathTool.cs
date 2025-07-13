namespace AssetTool
{
    [JsonAsset("DrawPolyPathToolBuilder")]
    public class UDrawPolyPathToolBuilder : UInteractiveToolBuilder
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("DrawPolyPathProperties")]
    public class UDrawPolyPathProperties : UInteractiveToolPropertySet
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("DrawPolyPathExtrudeProperties")]
    public class UDrawPolyPathExtrudeProperties : UInteractiveToolPropertySet
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("DrawPolyPathTool")]
    public class UDrawPolyPathTool : UInteractiveTool
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}