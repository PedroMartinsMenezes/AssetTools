namespace AssetTool
{
    [JsonAsset("FractureMaterialsSettings")]
    public class UFractureMaterialsSettings : UFractureToolSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("FractureToolMaterials")]
    public class UFractureToolMaterials : UFractureModalTool
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}