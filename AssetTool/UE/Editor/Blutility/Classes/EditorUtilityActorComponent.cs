namespace AssetTool
{
    [JsonAsset("EditorUtilityActorComponent")]
    public class UEditorUtilityActorComponent : UActorComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}