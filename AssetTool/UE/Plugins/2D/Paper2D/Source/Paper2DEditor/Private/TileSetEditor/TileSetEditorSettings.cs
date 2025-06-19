namespace AssetTool
{
    [JsonAsset("TileSetEditorSettings")]
    public class UTileSetEditorSettings : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}