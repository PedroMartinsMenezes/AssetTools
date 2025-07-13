namespace AssetTool
{
    [JsonAsset("LevelInstanceActorFactory")]
    public class ULevelInstanceActorFactory : UActorFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}