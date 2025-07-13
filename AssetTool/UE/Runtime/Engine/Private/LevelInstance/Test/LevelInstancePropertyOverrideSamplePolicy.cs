namespace AssetTool
{
    [JsonAsset("LevelInstancePropertyOverrideSamplePolicy")]
    public class ULevelInstancePropertyOverrideSamplePolicy : ULevelInstancePropertyOverridePolicy
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}