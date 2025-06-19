namespace AssetTool
{
    [JsonAsset("LevelFactory")]
    public class ULevelFactory : UFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}