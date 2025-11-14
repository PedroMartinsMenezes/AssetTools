namespace AssetTool
{
    [JsonAsset("LevelInstanceActorFactory")]
    public class ULevelInstanceActorFactory : UActorFactory
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}