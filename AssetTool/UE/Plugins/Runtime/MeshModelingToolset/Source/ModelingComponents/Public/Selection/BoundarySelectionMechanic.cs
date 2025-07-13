namespace AssetTool
{
    [JsonAsset("BoundarySelectionMechanic")]
    public class UBoundarySelectionMechanic : UMeshTopologySelectionMechanic
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}