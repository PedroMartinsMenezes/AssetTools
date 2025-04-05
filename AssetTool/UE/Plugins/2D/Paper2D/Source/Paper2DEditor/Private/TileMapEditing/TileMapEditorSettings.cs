namespace AssetTool
{
    [JsonAsset("TileMapEditorSettings")]
    public class UTileMapEditorSettings : UObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}