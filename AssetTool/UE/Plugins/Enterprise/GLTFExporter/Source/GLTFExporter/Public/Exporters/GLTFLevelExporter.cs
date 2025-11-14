namespace AssetTool
{
    [JsonAsset("GLTFLevelExporter")]
    public class UGLTFLevelExporter : UGLTFExporter
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}