namespace AssetTool
{
    [JsonAsset("LevelFactory")]
    public class ULevelFactory : UFactory
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}