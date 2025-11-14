namespace AssetTool
{
    [JsonAsset("TileMapEditorSettings")]
    public class UTileMapEditorSettings : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}