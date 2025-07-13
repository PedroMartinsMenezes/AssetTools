namespace AssetTool
{
    [JsonAsset("LevelInstancePropertyOverrideContainer")]
    public class ULevelInstancePropertyOverrideContainer : UActorDescContainer
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}