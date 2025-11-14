namespace AssetTool
{
    [JsonAsset("FractureConvexSettings")]
    public class UFractureConvexSettings : UFractureToolSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("FractureConvexActions")]
    public class UFractureConvexActions : UFractureToolSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("FractureToolConvex")]
    public class UFractureToolConvex : UFractureModalTool
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}