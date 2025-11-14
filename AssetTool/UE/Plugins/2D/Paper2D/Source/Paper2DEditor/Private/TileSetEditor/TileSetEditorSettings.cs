namespace AssetTool
{
    [JsonAsset("TileSetEditorSettings")]
    public class UTileSetEditorSettings : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}