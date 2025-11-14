namespace AssetTool
{
    [JsonAsset("FractureMeshCutSettings")]
    public class UFractureMeshCutSettings : UFractureToolSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("FractureToolMeshCut")]
    public class UFractureToolMeshCut : UFractureToolCutterBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}