namespace AssetTool
{
    [JsonAsset("LevelInstancePropertyOverrideSamplePolicy")]
    public class ULevelInstancePropertyOverrideSamplePolicy : ULevelInstancePropertyOverridePolicy
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}