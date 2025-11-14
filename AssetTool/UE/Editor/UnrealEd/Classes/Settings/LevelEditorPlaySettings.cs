namespace AssetTool
{
    [JsonAsset("CommonResolutionMenuContext")]
    public class UCommonResolutionMenuContext : UToolMenuContextBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("LevelEditorPlaySettings")]
    public class ULevelEditorPlaySettings : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}