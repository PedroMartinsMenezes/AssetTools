namespace AssetTool
{
    [JsonAsset("EditorUtilityActorComponent")]
    public class UEditorUtilityActorComponent : UActorComponent
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}