namespace AssetTool
{
    [JsonAsset("LightWeightInstanceStaticMeshManager")]
    public class ALightWeightInstanceStaticMeshManager : ALightWeightInstanceManager
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}