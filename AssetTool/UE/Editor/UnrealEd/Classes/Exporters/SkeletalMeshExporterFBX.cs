namespace AssetTool
{
    [JsonAsset("SkeletalMeshExporterFBX")]
    public class USkeletalMeshExporterFBX : UExporterFBX
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}