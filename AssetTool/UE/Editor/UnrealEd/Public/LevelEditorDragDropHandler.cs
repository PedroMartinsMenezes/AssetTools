namespace AssetTool
{
    [JsonAsset("LevelEditorDragDropHandler")]
    public class ULevelEditorDragDropHandler : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}