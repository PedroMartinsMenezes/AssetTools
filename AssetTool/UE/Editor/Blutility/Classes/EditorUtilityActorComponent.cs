namespace AssetTool
{
    [JsonAsset("EditorUtilityActorComponent")]
    public class UEditorUtilityActorComponent : UActorComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}