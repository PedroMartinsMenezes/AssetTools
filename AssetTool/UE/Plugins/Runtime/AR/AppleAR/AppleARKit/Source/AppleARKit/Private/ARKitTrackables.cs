namespace AssetTool
{
    [JsonAsset("ARKitMeshGeometry")]
    public class UARKitMeshGeometry : UARMeshGeometry
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}