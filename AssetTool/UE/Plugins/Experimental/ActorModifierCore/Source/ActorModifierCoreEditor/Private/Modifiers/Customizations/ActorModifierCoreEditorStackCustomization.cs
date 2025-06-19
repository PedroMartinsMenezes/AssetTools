namespace AssetTool
{
    [JsonAsset("ActorModifierCoreEditorStackCustomization")]
    public class UActorModifierCoreEditorStackCustomization : UOperatorStackEditorStackCustomization
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}