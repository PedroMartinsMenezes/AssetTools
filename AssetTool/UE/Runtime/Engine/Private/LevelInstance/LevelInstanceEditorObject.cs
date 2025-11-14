namespace AssetTool
{
    [JsonAsset("LevelInstanceEditorObject")]
    public class ULevelInstanceEditorObject : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}