namespace AssetTool
{
    [JsonAsset("MeshTopologySelectionMechanicProperties")]
    public class UMeshTopologySelectionMechanicProperties : UInteractiveToolPropertySet
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MeshTopologySelectionMechanic")]
    public class UMeshTopologySelectionMechanic : UInteractionMechanic
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}