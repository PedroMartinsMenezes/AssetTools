namespace AssetTool
{
    [JsonAsset("SaveGame")]
    public class USaveGame : UObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("LocalPlayerSaveGame")]
    public class ULocalPlayerSaveGame : USaveGame
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}