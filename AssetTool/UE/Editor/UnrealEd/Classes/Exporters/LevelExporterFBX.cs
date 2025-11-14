namespace AssetTool
{
    [JsonAsset("LevelExporterFBX")]
    public class ULevelExporterFBX : UExporterFBX
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}