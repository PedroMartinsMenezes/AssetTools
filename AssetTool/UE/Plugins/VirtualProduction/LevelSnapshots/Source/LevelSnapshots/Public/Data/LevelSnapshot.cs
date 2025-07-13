namespace AssetTool
{
    [JsonAsset("LevelSnapshot")]
    public class ULevelSnapshot : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}