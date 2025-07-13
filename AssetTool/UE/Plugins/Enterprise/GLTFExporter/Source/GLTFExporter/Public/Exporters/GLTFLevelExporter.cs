namespace AssetTool
{
    [JsonAsset("GLTFLevelExporter")]
    public class UGLTFLevelExporter : UGLTFExporter
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}