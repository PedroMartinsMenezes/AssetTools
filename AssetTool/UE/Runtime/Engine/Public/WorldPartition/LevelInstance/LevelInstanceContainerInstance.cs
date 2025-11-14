namespace AssetTool
{
    [JsonAsset("LevelInstanceContainerInstance")]
    public class ULevelInstanceContainerInstance : UActorDescContainerInstance
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}