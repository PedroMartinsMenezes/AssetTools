namespace AssetTool
{
    [JsonAsset("LightWeightInstanceStaticMeshManager")]
    public class ALightWeightInstanceStaticMeshManager : ALightWeightInstanceManager
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}