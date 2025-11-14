namespace AssetTool
{
    [JsonAsset("LevelInstancePropertyOverrideContainer")]
    public class ULevelInstancePropertyOverrideContainer : UActorDescContainer
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}