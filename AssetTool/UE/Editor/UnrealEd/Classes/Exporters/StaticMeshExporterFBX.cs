namespace AssetTool
{
    [JsonAsset("StaticMeshExporterFBX")]
    public class UStaticMeshExporterFBX : UExporterFBX
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}