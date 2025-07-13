namespace AssetTool
{
    [JsonAsset("LevelInstanceEditorObject")]
    public class ULevelInstanceEditorObject : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}