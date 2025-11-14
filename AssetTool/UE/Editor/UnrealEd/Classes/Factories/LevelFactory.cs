namespace AssetTool
{
    [JsonAsset("LevelFactory")]
    public class ULevelFactory : UFactory
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}