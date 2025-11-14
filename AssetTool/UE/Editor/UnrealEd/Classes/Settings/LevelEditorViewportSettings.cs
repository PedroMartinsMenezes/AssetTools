namespace AssetTool
{
    [JsonAsset("LevelEditorViewportSettings")]
    public class ULevelEditorViewportSettings : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}