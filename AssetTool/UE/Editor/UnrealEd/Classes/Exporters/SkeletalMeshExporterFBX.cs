namespace AssetTool
{
    [JsonAsset("SkeletalMeshExporterFBX")]
    public class USkeletalMeshExporterFBX : UExporterFBX
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}