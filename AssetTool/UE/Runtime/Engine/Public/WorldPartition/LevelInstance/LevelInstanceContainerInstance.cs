namespace AssetTool
{
    [JsonAsset("LevelInstanceContainerInstance")]
    public class ULevelInstanceContainerInstance : UActorDescContainerInstance
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}