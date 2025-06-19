namespace AssetTool
{
    [JsonAsset("LevelExporterFBX")]
    public class ULevelExporterFBX : UExporterFBX
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}