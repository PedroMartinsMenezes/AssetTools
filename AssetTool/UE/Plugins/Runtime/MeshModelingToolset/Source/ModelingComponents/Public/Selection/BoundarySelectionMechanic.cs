namespace AssetTool
{
    [JsonAsset("BoundarySelectionMechanic")]
    public class UBoundarySelectionMechanic : UMeshTopologySelectionMechanic
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}