namespace AssetTool
{
    [JsonAsset("FractureToolAddEmbeddedGeometry")]
    public class UFractureToolAddEmbeddedGeometry : UFractureActionTool
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("FractureToolAutoEmbedGeometry")]
    public class UFractureToolAutoEmbedGeometry : UFractureActionTool
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("FractureToolFlushEmbeddedGeometrySettings")]
    public class UFractureToolFlushEmbeddedGeometrySettings : UFractureToolSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("FractureToolFlushEmbeddedGeometry")]
    public class UFractureToolFlushEmbeddedGeometry : UFractureModalTool
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}