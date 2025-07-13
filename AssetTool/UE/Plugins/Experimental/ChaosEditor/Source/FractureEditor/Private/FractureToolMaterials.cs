namespace AssetTool
{
    [JsonAsset("FractureMaterialsSettings")]
    public class UFractureMaterialsSettings : UFractureToolSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("FractureToolMaterials")]
    public class UFractureToolMaterials : UFractureModalTool
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}