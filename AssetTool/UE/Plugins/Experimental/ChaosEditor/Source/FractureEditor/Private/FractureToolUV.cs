namespace AssetTool
{
    [JsonAsset("FractureAutoUVSettings")]
    public class UFractureAutoUVSettings : UFractureToolSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("FractureToolAutoUV")]
    public class UFractureToolAutoUV : UFractureModalTool
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}