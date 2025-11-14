namespace AssetTool
{
    [JsonAsset("LevelSnapshot")]
    public class ULevelSnapshot : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}