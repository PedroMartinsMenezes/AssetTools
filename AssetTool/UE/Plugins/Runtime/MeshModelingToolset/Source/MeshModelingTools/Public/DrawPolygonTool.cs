namespace AssetTool
{
    [JsonAsset("DrawPolygonToolBuilder")]
    public class UDrawPolygonToolBuilder : UInteractiveToolBuilder
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("DrawPolygonToolStandardProperties")]
    public class UDrawPolygonToolStandardProperties : UInteractiveToolPropertySet
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("DrawPolygonToolSnapProperties")]
    public class UDrawPolygonToolSnapProperties : UInteractiveToolPropertySet
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("DrawPolygonTool")]
    public class UDrawPolygonTool : UInteractiveTool
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}