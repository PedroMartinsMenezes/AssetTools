namespace AssetTool
{
    [JsonAsset("PolygonSelectionMechanicProperties")]
    public class UDEPRECATED_PolygonSelectionMechanicProperties : UMeshTopologySelectionMechanicProperties
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PolygonSelectionMechanic")]
    public class UPolygonSelectionMechanic : UMeshTopologySelectionMechanic
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}