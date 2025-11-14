namespace AssetTool
{
    [JsonAsset("LevelEditorDragDropHandler")]
    public class ULevelEditorDragDropHandler : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}