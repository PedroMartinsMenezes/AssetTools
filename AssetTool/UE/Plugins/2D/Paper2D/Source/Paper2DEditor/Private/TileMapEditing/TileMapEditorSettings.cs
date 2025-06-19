namespace AssetTool
{
    [JsonAsset("TileMapEditorSettings")]
    public class UTileMapEditorSettings : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}